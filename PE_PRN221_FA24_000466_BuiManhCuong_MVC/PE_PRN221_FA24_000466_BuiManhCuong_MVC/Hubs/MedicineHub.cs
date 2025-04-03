using Microsoft.AspNetCore.SignalR;

namespace PE_PRN221_FA24_000466_BuiManhCuong_MVC.Hubs
{
    public class MedicineHub : Hub
    {
        public async Task MedicineDelete()
        {
            await Clients.All.SendAsync("ReceiveMedicineDelete");
        }
    }
}
