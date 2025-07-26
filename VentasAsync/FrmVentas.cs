using VentasAsync.Model.Commands;

namespace VentasAsync
{
    public partial class FrmVentas : Form
    {
        private readonly VentaCommands _ventaCommands;

        public FrmVentas()
        {
            InitializeComponent();
            _ventaCommands = new VentaCommands();
        }
    }
}
