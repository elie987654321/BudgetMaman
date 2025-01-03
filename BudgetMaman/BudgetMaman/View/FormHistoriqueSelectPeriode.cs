using BudgetMaman.View.ClassesView;
using BudgetMaman.View.InterfaceView;

namespace BudgetMaman.View
{
    public partial class FormHistoriqueSelectPeriode : Form
    {
        IPresenterClass presenter;

        public FormHistoriqueSelectPeriode()
        {
            InitializeComponent();
            FillListView();
        }

        public void FillListView()
        {
        }
    }
}
