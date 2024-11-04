using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace projekt_manager
{
    public partial class sugo : UserControl
    {
        List<string[]> UserManual = new List<string[]>();
        public sugo()
        {
            InitializeComponent();
        }


        private void loadUserManual(string s)
        {
            foreach (string[] an in X.lekerdez(s))
            {
                UserManual.Add(an);
            }
        }
        private void loadArticleList(List<string[]> li)
        {
            string aLine;
            for (int i = 0; i < li.Count; i++)
            {
                aLine = "";
                aLine += $"{li[i][0]} - {li[i][1]}";
                ArticleList.Items.Add(aLine);
            }
        }
        private string getSelectedId(string s)
        {
            string[] t = s.Split(' ');
            return t[0];
        }
        private string provideDataToReadingSite(string s)
        {
            String readThis = "";

            for (int i = 0; i < UserManual.Count(); i++)
            {
                if (UserManual[i][0].Equals(s))
                {
                    string[] data = UserManual[i][2].Split(new string[] { "<br>" }, StringSplitOptions.None);
                    foreach (string asd in data)
                    {
                        readThis += $"{asd}\n";
                    }
                }
            }
            return readThis;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sLine = ArticleList.SelectedItem.ToString();
            ReadingSite.Text = provideDataToReadingSite(getSelectedId(sLine));
        }

        private void sugo_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM guide";
            if (ArticleList.Items.Count > 0) { ArticleList.Items.Clear(); }
            if (UserManual.Count > 0) { UserManual.Clear(); }

            loadUserManual(query);
            loadArticleList(UserManual);
        }
    }
}
