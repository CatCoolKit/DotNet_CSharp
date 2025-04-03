using Microsoft.AspNetCore.SignalR;

namespace PharmaceuticalManagement_BuiManhCuong.Hubs
{
    public class MedicineHub : Hub
    {
        public async Task MedicineDelete()
        {
            await Clients.All.SendAsync("ReceiveMedicineDelete");
        }
    }

}
