using EmpManage.Models;

namespace EmpManage.ViewModels
{
    public class HomeDetailsViewModel
    {
        #region Properties

        public Employee? Employee { get; set; }    // nullable
        public Employee PageTitle { get; set; }
        #endregion
    }
}
