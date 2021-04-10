using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Libraries
{
    class Function
    {


        public void ClearTextInTextBox(TextBox [] textbox)
        {
            for(int i = 0;i < textbox.Length; i++)
            {
                textbox[i].Text = "";
            }
        }

        public void ClearTextInComboBox(ComboBox[] combobox)
        {
            for (int i = 0; i < combobox.Length; i++)
            {
                combobox[i].SelectedIndex = -1;
            }
        }

        public void DataGridRowToTextBox(DataGridView dgv, TextBox[] textbox, DataGridViewCellEventArgs e, int startIndex = 0) {

            // selecting the header result in exception thus, must return nothing.
            if (e.RowIndex == -1) return;

            DataGridViewRow row = dgv.Rows[e.RowIndex];
            var totalColumn = textbox.Length;

            for (int i = startIndex; i < totalColumn; i++)
            {
                textbox[i].Text = row.Cells[i].Value.ToString();
            }
        }

        public string DataGridRowToString(DataGridView dgv, int columnIndex, DataGridViewCellEventArgs e)
        {

            // selecting the header result in exception thus, must return nothing.
            if (e.RowIndex == -1) return "";
            DataGridViewRow row = dgv.Rows[e.RowIndex];
            return row.Cells[columnIndex].Value.ToString();
        }


        public void DataGridRowToCombobox(DataGridView dgv,int columnIndex, ComboBox combobox, DataGridViewCellEventArgs e)
        {
            // selecting the header result in exception thus, must return nothing.
            if (e.RowIndex == -1) return;

            DataGridViewRow row = dgv.Rows[e.RowIndex];
            combobox.Text = row.Cells[columnIndex].Value.ToString();
            
        }

        public void DataGridHeaderToComboBox(DataGridView dgv, ComboBox combobox)
        {
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                combobox.Items.Add(column.HeaderText.ToString());
            }
            combobox.SelectedIndex = 0;
        }

        public void FilterTable(DataTable dt, DataGridView dgv, TextBox textBox,ComboBox comboBox = null, CheckBox checkbox=null)
        {
            StringBuilder sb = new StringBuilder("");

            int count = dgv.ColumnCount;
            for (int i = 0; i < count; i++)
            {
                if (i != count - 1)
                {
                    sb.Append("(convert(" + dgv.Columns[i].DataPropertyName + ",'System.String') LIKE '%" + textBox.Text + "%') OR ");
                }
                else
                {
                    sb.Append("(convert(" + dgv.Columns[i].DataPropertyName + ",'System.String') LIKE '%" + textBox.Text + "%')");
                }
            }
            if (checkbox != null)
            {
                if (checkbox.Checked)
                {
                    sb.Clear();
                    string comboBoxText = comboBox.Text;
                    comboBoxText = comboBoxText.Replace(" ",String.Empty);
                    sb.Append("(convert(" + dgv.Columns[comboBoxText].DataPropertyName + ",'System.String') LIKE '%" + textBox.Text + "%')");
                }
            }
            // string syntax = "(convert(ID,'System.String') LIKE '%" + textBox.Text + "%')";
            DataView dv = dt.DefaultView;
            dv.RowFilter = sb.ToString();
            dgv.DataSource = dv;
            
        }

        // jump to specific section by clicking the label.
        public void JumpToSection(Control ControlToClick, Control Destination, UserControl us)
        {
            ControlToClick.Click += delegate (object sender, EventArgs e)
            {
                Destination.Focus();
                us.Focus();
            };
        }

        public string ToUpperFirstLetter(string word)
        {
            word = word[0].ToString().ToUpper() + word.Substring(1, word.Length - 1);
            return word;
        }

        public bool IsStringMatchToRegex(string input,string pattern)
        {
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStringNotEmpty(string[] text)
        {
            for(int i = 0; i < text.Length; i++)
            {
                if (text[i].Trim().Equals(""))
                {
                    return false;
                }
            }
            return true;

        }

        public void ReplaceLabel(Label[] label, string value)
        {
            for(int i = 0; i < label.Length; i++)
            {
                label[i].Text = value;
            }
        }

        public void SetPlaceHolder(TextBox textbox, string placeholder, bool isPassword = false)
        {
            textbox.Text = placeholder;
            textbox.GotFocus += delegate (object sender, EventArgs e)
            {
                if (textbox.Text == placeholder && textbox.ForeColor == Color.Gray)
                {
                    if (isPassword)
                    {
                        textbox.PasswordChar = '\u25CF';
                    }
                    textbox.Text = "";
                    textbox.ForeColor = Color.Black;
                }
            };

            textbox.LostFocus += delegate (object sender, EventArgs e)
            {
                if (textbox.Text == "" && textbox.ForeColor == Color.Black)
                {
                    if (isPassword)
                    {
                        textbox.PasswordChar = '\0';
                    }
                    textbox.Text = placeholder;
                    textbox.ForeColor = Color.Gray;
                }
            };
        }

        
    }
}
