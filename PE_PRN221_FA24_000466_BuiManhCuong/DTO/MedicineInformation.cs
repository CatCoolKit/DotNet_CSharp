using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DTO;

public partial class MedicineInformation
{
    [Required(ErrorMessage = "Medicine Id is required.")]
    public string MedicineId { get; set; } = null!;

    [Required(ErrorMessage = "Medicine Name is required.")]
    public string MedicineName { get; set; } = null!;

    [Required(ErrorMessage = "Active Ingredients are required.")]
    [StringLength(int.MaxValue, MinimumLength = 11, ErrorMessage = "Active Ingredients must be at least 11 characters.")]
    [RegularExpression(@"^([A-Z0-9][a-zA-Z0-9]*\s*)*$", ErrorMessage = "Each word must begin with a capital letter or a number. Active Ingredients cannot contain special characters.")]
    public string ActiveIngredients { get; set; } = null!;

    [Required(ErrorMessage = "Expiration Date is required.")]
    public string? ExpirationDate { get; set; }

    [Required(ErrorMessage = "Dosage Form is required.")]
    public string DosageForm { get; set; } = null!;

    [Required(ErrorMessage = "Warnings and Precautions are required.")]
    public string WarningsAndPrecautions { get; set; } = null!;

    [Required(ErrorMessage = "Please select a manufacturer.")]
    public string? ManufacturerId { get; set; }

    public virtual Manufacturer? Manufacturer { get; set; }

    // public DateTime CreatedAt { get; set; }
}
