using NET_RGR.Core;
using NET_RGR.Core.Ozera;
using System;
using System.Windows.Forms;

namespace NET_RGR
{
    public partial class MainForm : Form
    {
        ParserWorker<Lake[]> parser;

        public MainForm()
        {
            InitializeComponent();
            parser = new ParserWorker<Lake[]>(
                    new OzeraParser()
                );
            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;
        }

        private void Parser_OnNewData(object arg1, Lake[] arg2)
        {
            foreach (var lake in arg2) 
            {
                var listViewElem = listViewLakes.Items.Add(lake.Name);
                listViewElem.Tag = lake.Name;
                listViewElem.SubItems.Add(lake.Location);
                listViewElem.SubItems.Add(lake.BasinDistrinct);
                listViewElem.SubItems.Add(lake.RiverBasin);
                listViewElem.SubItems.Add(lake.Square);
            }
        }

        private void Parser_OnCompleted(object obj)
        {
            MessageBox.Show("Парсинг успешно завершен!");
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            parser.Settings = new OzeraSettings((int)numericStart.Value, (int)numericEnd.Value);
            parser.Start();
        }

        private void buttonAbort_Click(object sender, EventArgs e)
        {
            parser.Abort();
        }

        private void buttonLoadingIntoDB_Click(object sender, EventArgs e)
        {
            //обход всех строк listViewLakes
            for (int i = 0; i < listViewLakes.Items.Count; i++)
            {
                //проверка, существует ли данная строка в таблице
                bool isContains = false;
                foreach (DataGridViewRow row in lakesDataGridView.Rows) {
                    if (((string)row.Cells[1].Value == listViewLakes.Items[i].SubItems[0].Text) &&
                        ((string)row.Cells[2].Value == listViewLakes.Items[i].SubItems[1].Text) &&
                        ((string)row.Cells[3].Value == listViewLakes.Items[i].SubItems[2].Text) &&
                        ((string)row.Cells[4].Value == listViewLakes.Items[i].SubItems[3].Text) &&
                        ((string)row.Cells[5].Value == listViewLakes.Items[i].SubItems[4].Text))
                    {
                        isContains = true;
                        break;
                    }
                }
                //если не существует, вставляем строку
                if (isContains == false)
                {
                    lakesTableAdapter.Insert(
                        listViewLakes.Items[i].SubItems[0].Text,
                        listViewLakes.Items[i].SubItems[1].Text,
                        listViewLakes.Items[i].SubItems[2].Text,
                        listViewLakes.Items[i].SubItems[3].Text,
                        listViewLakes.Items[i].SubItems[4].Text
                        );
                }
            }
            lakesTableAdapter.Fill(nET_RGRDataSet.Lakes);
        }

        private void lakesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow addedRow in lakesDataGridView.Rows) {
                if (Convert.ToInt32(addedRow.Cells[0].Value) < 0) {
                    bool isContains = false;
                    foreach (DataGridViewRow row in lakesDataGridView.Rows)
                    {
                        if (((string)row.Cells[1].Value == (string)row.Cells[1].Value) &&
                            ((string)row.Cells[2].Value == (string)row.Cells[2].Value) &&
                            ((string)row.Cells[3].Value == (string)row.Cells[3].Value) &&
                            ((string)row.Cells[4].Value == (string)row.Cells[4].Value) &&
                            ((string)row.Cells[5].Value == (string)row.Cells[5].Value))
                        {
                            isContains = true;
                            break;
                        }
                    }
                    if (isContains) 
                    {
                        MessageBox.Show("Ошибка добавления строки - найден дубликат!");
                        lakesDataGridView.Rows.Remove(addedRow);
                    }
                }
            }
            this.Validate();
            this.lakesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nET_RGRDataSet);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nET_RGRDataSet.Lakes". При необходимости она может быть перемещена или удалена.
            this.lakesTableAdapter.Fill(this.nET_RGRDataSet.Lakes);

        }

        private void buttonClearListView_Click(object sender, EventArgs e)
        {
            listViewLakes.Items.Clear();
        }

        private void listViewLakes_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (ListViewItem item in listViewLakes.SelectedItems)
                {
                    listViewLakes.Items.Remove(item);
                }
            }
        }

        private void lakesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Ошибка ввода информации!");
        }
    }
}
