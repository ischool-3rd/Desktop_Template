using FISCA;
using FISCA.Permission;
using FISCA.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_Template
{
    public class Program
    {
        //參考Fisca.dll,讓DLL可被掃描
        [MainMethod()]
        public static void Main()
        {
            RibbonBarItem StudentReports = K12.Presentation.NLDPanels.Student.RibbonBarItems["資料區塊"];
            StudentReports["分類"]["功能名稱"].Enable = Permissions.功能名稱權限;
            StudentReports["分類"]["功能名稱"].Click += delegate
            {
                //開啟功能
                Form1 f = new Form1();
                f.ShowDialog();
            };

            //參考 - FISCA.Permission.dll 增加權限代碼
            Catalog catalog08 = RoleAclSource.Instance["模組名稱"]["功能區"];
            catalog08.Add(new RibbonFeature(Permissions.功能名稱, "功能名稱"));

        }
    }
}
