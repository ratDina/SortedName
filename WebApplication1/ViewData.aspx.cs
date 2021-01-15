using System;
using System.Collections.Generic;
using System.Web;


namespace AppSortedName
{
    public partial class ViewData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLook_Click(object sender, EventArgs e)
        {
            var d = new sortLib();
            var data = d.unsortedList();

            for (int x = 0; x < data.Count; x++)
            {
                var num = x + 1;
                lbFile.Text += "<tr><td>" + num + ". " + data[x] + "</td></tr>";
            }

            var listName = d.GetLastName(data);
            var dataSort = d.CreateSortedList(listName, data);

            for (int x = 0; x < dataSort.Count; x++)
            {
                var num = x + 1;
                lbSort.Text += "<tr><td>" + num + ". " + dataSort[x] + "</td></tr>";
            }

            lbInfo.Text = "File Location : " + d.InfoFileSort();
        }
    }
}