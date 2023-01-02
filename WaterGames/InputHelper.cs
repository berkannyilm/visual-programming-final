using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterGames
{
    public class InputHelper
    {
        ErrorProvider errorProvider = new ErrorProvider();
        public bool status = true;
        public void CheckTextBoxValues(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    status = false;
                    errorProvider.SetError(textBox, "Bu alanı boş bırakmayınız!");
                    return;
                }
                status = true;
                errorProvider.Clear();
                return;
            }
        }
        public void CheckComboboxValues(params ComboBox[] comboBoxes)
        {
            foreach (var comboBox in comboBoxes)
            {
                if (comboBox.SelectedIndex == -1)
                {
                    status = false;
                    errorProvider.SetError(comboBox, "Lütfen seçim yapınız!");
                    return;
                }

                status = true;
                errorProvider.Clear();
            }

        }

        public void CheckDateTimePickers(params DateTimePicker[] dateTimePickers)
        {
            foreach (var dateTimePicker in dateTimePickers)
            {
                if (dateTimePicker.Value.Date == null)
                {
                    status = false;
                    errorProvider.SetError(dateTimePicker, "Tarih seçiniz!");
                    return;
                }
                status = true;
                errorProvider.Clear();
            }
        }

        public void DateTimePickerDateTimeComparison(DateTimePicker dateTimePicker1, DateTimePicker dateTimePicker2)
        {
            if (dateTimePicker1.Value.Date >= dateTimePicker2.Value.Date)
            {
                status = false;
                errorProvider.SetError(dateTimePicker2, "Lütfen başlangıç tarihinden büyük bir tarih seçin!");
                return;
            }

            status = true;
            errorProvider.Clear();
            return;

        }
        public void ClearDateTimePicker(params DateTimePicker[] dateTimePickers)
        {
            foreach (var dateTimePicker in dateTimePickers)
            {
                dateTimePicker.Value = DateTime.Now;
            }
        }


        public void ClearTextBox(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.Text = String.Empty;
            }
        }
        public void ClearCombobox(params ComboBox[] comboBoxes)
        {
            foreach (var comboBox in comboBoxes)
            {
                comboBox.Text = "";
            }
        }

    }
}
