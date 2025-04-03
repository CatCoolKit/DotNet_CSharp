using Data;
using DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using PE_PRN221_FA24_000466_BuiManhCuong_MVC.Hubs;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PE_PRN221_FA24_000466_BuiManhCuong_MVC.Controllers
{
    public class MedicineInformationsController : Controller
    {
        private readonly IMedicineRepository medicineRepository;
        private readonly IManufacturerRepository manufacturerRepository;
        private readonly IHubContext<MedicineHub> _hubContext;

        public MedicineInformationsController(IMedicineRepository medicineRepository, IManufacturerRepository manufacturerRepository, IHubContext<MedicineHub> hubContext)
        {
            this.medicineRepository = medicineRepository;
            this.manufacturerRepository = manufacturerRepository;
            _hubContext = hubContext;
        }

        [AllowAnonymous]
        public async Task<IActionResult> ListMedicine(int pageNumber = 1)
        {
            int pageSize = 3;
            int totalRecords = await medicineRepository.GetTotalMedicinesAsync();
            int totalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);

            if (pageNumber < 1) pageNumber = 1;
            if (pageNumber > totalPages && totalPages > 0) pageNumber = totalPages;

            var medicines = await medicineRepository.GetPagedMedicinesAsync(pageNumber, pageSize);

            ViewBag.PageNumber = pageNumber;
            ViewBag.TotalPages = totalPages;

            return View(medicines);
        }

        [Authorize(Roles = "2,3")]
        public async Task<IActionResult> Index(string activeIngredients, string expirationDate, string warningsAndPrecautions, int pageNumber = 1)
        {
            int pageSize = 3;
            var medicines = new System.Collections.Generic.List<DTO.MedicineInformation>();
            int totalRecords = 0;
            int totalPages = 0;

            if (string.IsNullOrEmpty(activeIngredients) && string.IsNullOrEmpty(expirationDate) && string.IsNullOrEmpty(warningsAndPrecautions))
            {
                totalRecords = await medicineRepository.GetTotalMedicinesAsync();
                totalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);

                if (pageNumber < 1) pageNumber = 1;
                if (pageNumber > totalPages && totalPages > 0) pageNumber = totalPages;

                medicines = await medicineRepository.GetPagedMedicinesAsync(pageNumber, pageSize);
            }
            else
            {
                var criteria = new MedicineSearchCriteria
                {
                    ActiveIngredients = activeIngredients,
                    ExpirationDate = expirationDate,
                    WarningsAndPrecautions = warningsAndPrecautions
                };

                var searchResults = await medicineRepository.FindMedicinesAsync(criteria);
                totalRecords = searchResults.Count;
                totalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);

                if (pageNumber < 1) pageNumber = 1;
                if (pageNumber > totalPages && totalPages > 0) pageNumber = totalPages;

                medicines = searchResults.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            }

            ViewBag.PageNumber = pageNumber;
            ViewBag.TotalPages = totalPages;

            return View(medicines);
        }

        // GET: MedicineInformations/Details/5
        [Authorize(Roles = "2, 3")]
        public async Task<IActionResult> Details(string id)
        {
            if (User.IsInRole("3"))
            {
                return PartialView("UnauthorizedCreate");
            }

            if (id == null)
            {
                return NotFound();
            }

            var medicineInformation = await medicineRepository.GetMedicineById(id);
            if (medicineInformation == null)
            {
                return NotFound();
            }

            return View(medicineInformation);
        }

        // GET: MedicineInformations/Create
        [Authorize(Roles = "2,3")]
        public IActionResult Create()
        {
            if (User.IsInRole("3"))
            {
                return PartialView("UnauthorizedCreate");
            }
            //ViewBag.ManufacturerId = new SelectList(manufacturerRepository.GetAllManufacturers(), "ManufacturerId", "ManufacturerId");
            ViewBag.ManufacturerId = new SelectList(manufacturerRepository.GetAllManufacturers(), "ManufacturerId", "ManufacturerName");
            return View();
        }

        // POST: MedicineInformations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "2")]
        public async Task<IActionResult> Create([Bind("MedicineId,MedicineName,ActiveIngredients,ExpirationDate,DosageForm,WarningsAndPrecautions,ManufacturerId")] MedicineInformation medicineInformation)
        {
            if (ModelState.IsValid)
            {
                medicineRepository.AddMedicine(medicineInformation);
                await _hubContext.Clients.All.SendAsync("ReceiveMedicineDelete");
                return RedirectToAction(nameof(Index));
            }
            return View(medicineInformation);
        }

        // GET: MedicineInformations/Edit/5
        [Authorize(Roles = "2, 3")]
        public async Task<IActionResult> Edit(string id)
        {
            if (User.IsInRole("3"))
            {
                return PartialView("UnauthorizedCreate");
            }

            if (id == null)
            {
                return NotFound();
            }

            var medicineInformation = await Task.Run(() => medicineRepository.GetMedicineById(id));
            if (medicineInformation == null)
            {
                return NotFound();
            }

            ViewBag.ManufacturerId = new SelectList(manufacturerRepository.GetAllManufacturers(), "ManufacturerId", "ManufacturerName");
            return View(medicineInformation);
        }

        // POST: MedicineInformations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "2")]
        public async Task<IActionResult> Edit(string id, [Bind("MedicineId,MedicineName,ActiveIngredients,ExpirationDate,DosageForm,WarningsAndPrecautions,ManufacturerId")] MedicineInformation medicineInformation)
        {
            if (id != medicineInformation.MedicineId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    medicineRepository.UpdateMedicine(medicineInformation);
                    await _hubContext.Clients.All.SendAsync("ReceiveMedicineDelete");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicineInformationExists(medicineInformation.MedicineId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(medicineInformation);
        }

        // GET: MedicineInformations/Delete/5
        [Authorize(Roles = "2, 3")]
        public async Task<IActionResult> Delete(string id)
        {
            if (User.IsInRole("3"))
            {
                return PartialView("UnauthorizedCreate");
            }

            if (id == null)
            {
                return NotFound();
            }

            var medicineInformation = await medicineRepository.GetMedicineById(id);
            if (medicineInformation == null)
            {
                return NotFound();
            }

            return View(medicineInformation);
        }

        // POST: MedicineInformations/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "2")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var medicine = await medicineRepository.GetMedicineById(id);
            if (medicine == null)
            {
                return NotFound();
            }

            await medicineRepository.DeleteMedicineByIdAsync(id);
            await _hubContext.Clients.All.SendAsync("ReceiveMedicineDelete");
            return RedirectToAction(nameof(Index));
        }

        private bool MedicineInformationExists(string id)
        {
            return medicineRepository.MedicineInformationExists(id);
        }

        [Authorize(Roles = "2,3")]
        public async Task<IActionResult> Search1(string searchString)
        {
            if (string.IsNullOrEmpty(searchString))
            {
                return View("Index", await medicineRepository.GetAllMedicinesAsync());
            }

            var medicines = await medicineRepository.FindMedicinesAsync(searchString);
            return View("ListMedicine", medicines);
        }

        //[Authorize(Roles = "2,3")]
        //public async Task<IActionResult> Search(string activeIngredients, string expirationDate, string warningsAndPrecautions)
        //{
        //    var criteria = new MedicineSearchCriteria
        //    {
        //        ActiveIngredients = activeIngredients,
        //        ExpirationDate = expirationDate,
        //        WarningsAndPrecautions = warningsAndPrecautions
        //    };

        //    var medicines = await medicineRepository.FindMedicinesAsync(criteria);
        //    return View("Index", medicines);
        //}
    }
}
