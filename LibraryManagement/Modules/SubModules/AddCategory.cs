using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.Libraries;

namespace LibraryManagement.Modules.SubModules
{
    public partial class AddCategory : UserControl
    {
        private static AddCategory _instance;
        public static AddCategory Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new AddCategory();
                }
                return _instance;
            }
        }

        private Database db = new Database("library");
        private Function func = new Function();
        private DataTable dtCategory = new DataTable();

        private string bookCategoryQuery = "SELECT category_name, strftime('%d/%m/%Y', created_at) as added_at FROM book_category " +
            "WHERE category_id > 0";

        public AddCategory()
        {
            InitializeComponent();
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
            db.RetrieveToTable(dtCategory, dgvCategory, bookCategoryQuery);

            func.JumpToSection(lblOption1, dgvCategory, this);
            func.JumpToSection(lblOption2, btnClear2, this);
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            func.DataGridRowToTextBox(dgvCategory,new TextBox[]{ txtBoxCategory},e);
            string getID = "SELECT category_id FROM book_category " +
                "WHERE category_name = @name";
            string []arr = db.RetrieveRowValues(getID,
                new string[] { "@name" },
                new string[] { txtBoxCategory.Text },
                new string[] { "category_id"});

            txtBoxCategoryId.Text = arr[0];
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            func.FilterTable(dtCategory, dgvCategory, txtBoxSearch);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string add = "INSERT INTO book_category(category_name) VALUES(@name)";

            if (!txtBoxAddCategory.Text.Trim().Equals(""))
            {
                db.Query(add,
                new string[] { "@name" },
                new string[] { func.ToUpperFirstLetter(txtBoxAddCategory.Text) });
                db.RetrieveToTable(dtCategory, dgvCategory, bookCategoryQuery);

                func.ClearTextInTextBox(new TextBox[] { txtBoxAddCategory });
            }
            else MessageBox.Show("Please enter a category.");
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            string edit = "UPDATE book_category SET category_name = @name " +
                "WHERE category_id = @id";

            if (!txtBoxCategoryId.Text.Equals(""))
            {
                if (!txtBoxCategory.Text.Trim().Equals(""))
                {
                    db.Query(edit,
                        new string[] { "@name", "@id" },
                        new string[] { txtBoxCategory.Text, txtBoxCategoryId.Text });
                    db.RetrieveToTable(dtCategory, dgvCategory, bookCategoryQuery);

                    func.ClearTextInTextBox(new TextBox[] { txtBoxCategoryId, txtBoxCategory });

                }
                else MessageBox.Show("Enter a category.");

            }
            else MessageBox.Show("Select category from table.");
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            string toNone = "UPDATE book SET category_id = 0 " +
                "WHERE category_id = @category_id";

            string delete = "DELETE FROM book_category WHERE category_id = @category_id";

            if (!txtBoxCategoryId.Text.Equals(""))
            {
                db.Query(toNone,
                    new string[] { "@category_id" },
                    new string[] { txtBoxCategoryId.Text });
                db.Query(delete,
                    new string[] { "@category_id" },
                    new string[] { txtBoxCategoryId.Text });
                db.RetrieveToTable(dtCategory, dgvCategory, bookCategoryQuery);

                func.ClearTextInTextBox(new TextBox[] { txtBoxCategoryId,txtBoxCategory });

            }
            else MessageBox.Show("Select category from table.");
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            func.ClearTextInTextBox(new TextBox[] { txtBoxAddCategory });
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            func.ClearTextInTextBox(new TextBox[] { txtBoxCategoryId,txtBoxCategory });
        }

    }
}
