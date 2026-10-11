using System.Drawing.Drawing2D;

namespace SMART
{
    internal sealed class CourseTimePickerDialog : Form
    {
        private readonly Label display = new();
        private readonly Label modeLabel = new();
        private readonly Panel dial = new();
        private readonly ComboBox minutePicker = new();
        private readonly Button amButton = new();
        private readonly Button pmButton = new();
        private readonly Button hoursButton = new();
        private readonly Button minutesButton = new();
        private readonly Button confirmButton = new();
        private int hour;
        private int minute;
        private bool isPm;
        private bool selectingMinutes;

        internal TimeSpan SelectedTime { get; private set; }

        internal CourseTimePickerDialog(TimeSpan? initialTime)
        {
            Text = "Select Time";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            ClientSize = new Size(390, 570);
            BackColor = Color.FromArgb(15, 23, 42);
            ForeColor = Color.White;
            Font = new Font("Bahnschrift", 10F);

            TimeSpan initial = initialTime ?? new TimeSpan(8, 0, 0);
            int hour24 = (int)initial.TotalHours % 24;
            hour = hour24 % 12;
            if (hour == 0) hour = 12;
            minute = initial.Minutes;
            isPm = hour24 >= 12;

            var title = new Label
            {
                Text = "Choose a time",
                Font = new Font("Bahnschrift", 16F, FontStyle.Bold),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                Bounds = new Rectangle(20, 12, 350, 30)
            };
            Controls.Add(title);

            display.SetBounds(28, 50, 334, 56);
            display.Font = new Font("Bahnschrift", 27F, FontStyle.Bold);
            display.TextAlign = ContentAlignment.MiddleCenter;
            display.ForeColor = Color.White;
            Controls.Add(display);

            hoursButton.Text = "Hour";
            minutesButton.Text = "Minute";
            StyleButton(hoursButton, new Rectangle(92, 112, 95, 34), true);
            StyleButton(minutesButton, new Rectangle(203, 112, 95, 34), false);
            hoursButton.Click += (_, _) => { selectingMinutes = false; UpdatePicker(); };
            minutesButton.Click += (_, _) => { selectingMinutes = true; UpdatePicker(); };
            Controls.Add(hoursButton);
            Controls.Add(minutesButton);

            dial.SetBounds(35, 157, 320, 260);
            dial.BackColor = Color.FromArgb(22, 33, 62);
            dial.Cursor = Cursors.Hand;
            dial.Paint += DrawDial;
            dial.MouseClick += Dial_MouseClick;
            Controls.Add(dial);

            modeLabel.SetBounds(45, 420, 100, 28);
            modeLabel.ForeColor = Color.FromArgb(195, 205, 225);
            modeLabel.TextAlign = ContentAlignment.MiddleLeft;
            Controls.Add(modeLabel);

            minutePicker.DropDownStyle = ComboBoxStyle.DropDownList;
            minutePicker.SetBounds(144, 420, 83, 28);
            minutePicker.BackColor = Color.FromArgb(22, 33, 62);
            minutePicker.ForeColor = Color.White;
            minutePicker.Items.AddRange(Enumerable.Range(0, 60).Select(n => (object)n.ToString("00")).ToArray());
            minutePicker.SelectedIndex = minute;
            minutePicker.SelectedIndexChanged += (_, _) =>
            {
                if (minutePicker.SelectedIndex >= 0) minute = minutePicker.SelectedIndex;
                UpdatePicker();
            };
            Controls.Add(minutePicker);

            StyleButton(amButton, new Rectangle(242, 417, 52, 34), !isPm);
            StyleButton(pmButton, new Rectangle(300, 417, 52, 34), isPm);
            amButton.Text = "AM";
            pmButton.Text = "PM";
            amButton.Click += (_, _) => { isPm = false; UpdatePicker(); };
            pmButton.Click += (_, _) => { isPm = true; UpdatePicker(); };
            Controls.Add(amButton);
            Controls.Add(pmButton);

            var cancel = new Button { Text = "Cancel", DialogResult = DialogResult.Cancel };
            StyleButton(cancel, new Rectangle(88, 500, 100, 42), false);
            Controls.Add(cancel);
            confirmButton.Text = "Confirm";
            StyleButton(confirmButton, new Rectangle(202, 500, 100, 42), true);
            confirmButton.Click += (_, _) =>
            {
                int hour24Value = hour % 12 + (isPm ? 12 : 0);
                SelectedTime = new TimeSpan(hour24Value, minute, 0);
                DialogResult = DialogResult.OK;
                Close();
            };
            Controls.Add(confirmButton);
            AcceptButton = confirmButton;
            CancelButton = cancel;
            UpdatePicker();
        }

        private void UpdatePicker()
        {
            display.Text = $"{hour:00}:{minute:00} { (isPm ? "PM" : "AM") }";
            modeLabel.Text = "Minute:";
            minutePicker.Enabled = selectingMinutes;
            hoursButton.BackColor = selectingMinutes ? Color.FromArgb(22, 33, 62) : Color.FromArgb(233, 69, 96);
            minutesButton.BackColor = selectingMinutes ? Color.FromArgb(233, 69, 96) : Color.FromArgb(22, 33, 62);
            amButton.BackColor = isPm ? Color.FromArgb(22, 33, 62) : Color.FromArgb(233, 69, 96);
            pmButton.BackColor = isPm ? Color.FromArgb(233, 69, 96) : Color.FromArgb(22, 33, 62);
            minutePicker.SelectedIndex = minute;
            dial.Invalidate();
        }

        private void Dial_MouseClick(object? sender, MouseEventArgs e)
        {
            int centerX = dial.ClientSize.Width / 2;
            int centerY = dial.ClientSize.Height / 2;
            int selectedPosition = -1;
            double nearestDistance = 42;
            for (int position = 0; position < 12; position++)
            {
                double angle = position * Math.PI / 6 - Math.PI / 2;
                int x = centerX + (int)(Math.Cos(angle) * 92);
                int y = centerY + (int)(Math.Sin(angle) * 92);
                double distance = Math.Sqrt(Math.Pow(e.X - x, 2) + Math.Pow(e.Y - y, 2));
                if (distance >= nearestDistance) continue;
                nearestDistance = distance;
                selectedPosition = position;
            }
            if (selectedPosition < 0) return;
            if (selectingMinutes)
            {
                minute = selectedPosition * 5;
                minutePicker.SelectedIndex = minute;
            }
            else
            {
                hour = selectedPosition == 0 ? 12 : selectedPosition;
                selectingMinutes = true;
            }
            UpdatePicker();
        }

        private void DrawDial(object? sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            int diameter = 224;
            int left = (dial.ClientSize.Width - diameter) / 2;
            int top = (dial.ClientSize.Height - diameter) / 2;
            using var face = new SolidBrush(Color.FromArgb(15, 23, 42));
            using var hand = new Pen(Color.FromArgb(233, 69, 96), 3F);
            using var hub = new SolidBrush(Color.FromArgb(233, 69, 96));
            e.Graphics.FillEllipse(face, left, top, diameter, diameter);
            int centerX = left + diameter / 2;
            int centerY = top + diameter / 2;
            int chosen = selectingMinutes ? minute / 5 : hour % 12;
            double angle = chosen * Math.PI / 6 - Math.PI / 2;
            int selectedX = centerX + (int)(Math.Cos(angle) * 84);
            int selectedY = centerY + (int)(Math.Sin(angle) * 84);
            e.Graphics.DrawLine(hand, centerX, centerY, selectedX, selectedY);
            e.Graphics.FillEllipse(hub, centerX - 5, centerY - 5, 10, 10);

            for (int position = 0; position < 12; position++)
            {
                int value = selectingMinutes ? position * 5 : position == 0 ? 12 : position;
                double itemAngle = position * Math.PI / 6 - Math.PI / 2;
                int x = centerX + (int)(Math.Cos(itemAngle) * 92);
                int y = centerY + (int)(Math.Sin(itemAngle) * 92);
                var bounds = new Rectangle(x - 20, y - 17, 40, 34);
                bool selected = selectingMinutes ? minute == value : hour == value;
                using var textBrush = new SolidBrush(selected ? Color.FromArgb(233, 69, 96) : Color.White);
                string label = selectingMinutes ? value.ToString("00") : value.ToString();
                TextRenderer.DrawText(e.Graphics, label, Font, bounds, textBrush.Color,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }

        private static void StyleButton(Button button, Rectangle bounds, bool accent)
        {
            button.Bounds = bounds;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = accent ? Color.FromArgb(233, 69, 96) : Color.FromArgb(90, 105, 135);
            button.FlatAppearance.BorderSize = 1;
            button.BackColor = accent ? Color.FromArgb(233, 69, 96) : Color.FromArgb(22, 33, 62);
            button.ForeColor = Color.White;
            button.Cursor = Cursors.Hand;
        }
    }
}
