using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PersonalCV
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.AboutTableAdapter dt = new DataSet1TableAdapters.AboutTableAdapter();
            Repeater1.DataSource = dt.GetAboutList();
            Repeater1.DataBind();

            DataSet1TableAdapters.ExperienceTableAdapter et = new DataSet1TableAdapters.ExperienceTableAdapter();
            Repeater2.DataSource = et.GetDataExperience();
            Repeater2.DataBind();

            DataSet1TableAdapters.EducationTableAdapter et2 = new DataSet1TableAdapters.EducationTableAdapter();
            Repeater3.DataSource = et2.GetDataEducationList();
            Repeater3.DataBind();

            DataSet1TableAdapters.HobbiesTableAdapter ht = new DataSet1TableAdapters.HobbiesTableAdapter();
            Repeater4.DataSource = ht.GetDataHobbiesList();
            Repeater4.DataBind();

            DataSet1TableAdapters.CertificatesTableAdapter ct = new DataSet1TableAdapters.CertificatesTableAdapter();
            Repeater5.DataSource = ct.GetDataCertificatesList();
            Repeater5.DataBind();

            DataSet1TableAdapters.SkillsTableAdapter st = new DataSet1TableAdapters.SkillsTableAdapter();
            Repeater6.DataSource = st.GetDataSkillsList();
            Repeater6.DataBind();


        }
    }
}