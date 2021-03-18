using VendingMachine;

namespace VendingMachineWPF
{
    class VendingMachineVM
    {
        public CanRack Rack { get; set; } = new CanRack();
        public CoinBox MainCoinBox { get; set; } = new CoinBox();
    }
}
