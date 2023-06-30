namespace Independent_work__diner
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_first_dish = new System.Windows.Forms.Label();
            this.label_salad = new System.Windows.Forms.Label();
            this.label_dessert = new System.Windows.Forms.Label();
            this.listBox_first_dish = new System.Windows.Forms.ListBox();
            this.listBox_salad = new System.Windows.Forms.ListBox();
            this.listBox_dessert = new System.Windows.Forms.ListBox();
            this.label_drink = new System.Windows.Forms.Label();
            this.listBox_drink = new System.Windows.Forms.ListBox();
            this.label_sauce = new System.Windows.Forms.Label();
            this.listBox_sause = new System.Windows.Forms.ListBox();
            this.label_jam = new System.Windows.Forms.Label();
            this.listBox_jam = new System.Windows.Forms.ListBox();
            this.textBox_first_dish = new System.Windows.Forms.TextBox();
            this.textBox_salad = new System.Windows.Forms.TextBox();
            this.textBox_desserts = new System.Windows.Forms.TextBox();
            this.textBox_drink = new System.Windows.Forms.TextBox();
            this.textBox_sause = new System.Windows.Forms.TextBox();
            this.textBox_jam = new System.Windows.Forms.TextBox();
            this.label_price_first = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_first_dish
            // 
            this.label_first_dish.AutoSize = true;
            this.label_first_dish.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_first_dish.Location = new System.Drawing.Point(12, 19);
            this.label_first_dish.Name = "label_first_dish";
            this.label_first_dish.Size = new System.Drawing.Size(156, 25);
            this.label_first_dish.TabIndex = 1;
            this.label_first_dish.Text = "Первое блюдо";
            // 
            // label_salad
            // 
            this.label_salad.AutoSize = true;
            this.label_salad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_salad.Location = new System.Drawing.Point(230, 19);
            this.label_salad.Name = "label_salad";
            this.label_salad.Size = new System.Drawing.Size(88, 25);
            this.label_salad.TabIndex = 2;
            this.label_salad.Text = "Салаты";
            // 
            // label_dessert
            // 
            this.label_dessert.AutoSize = true;
            this.label_dessert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_dessert.Location = new System.Drawing.Point(394, 19);
            this.label_dessert.Name = "label_dessert";
            this.label_dessert.Size = new System.Drawing.Size(100, 25);
            this.label_dessert.TabIndex = 3;
            this.label_dessert.Text = "Десерты";
            // 
            // listBox_first_dish
            // 
            this.listBox_first_dish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_first_dish.FormattingEnabled = true;
            this.listBox_first_dish.ItemHeight = 20;
            this.listBox_first_dish.Items.AddRange(new object[] {
            "Пюре с котлетой",
            "Пельмени",
            "Плов",
            "Макароны с сосисками"});
            this.listBox_first_dish.Location = new System.Drawing.Point(12, 66);
            this.listBox_first_dish.Name = "listBox_first_dish";
            this.listBox_first_dish.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_first_dish.Size = new System.Drawing.Size(171, 84);
            this.listBox_first_dish.TabIndex = 5;
            this.listBox_first_dish.SelectedValueChanged += new System.EventHandler(this.listBox_first_dish_SelectedValueChanged);
            // 
            // listBox_salad
            // 
            this.listBox_salad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_salad.FormattingEnabled = true;
            this.listBox_salad.ItemHeight = 20;
            this.listBox_salad.Items.AddRange(new object[] {
            "Селедка под шубой",
            "Оливье",
            "Цезарь",
            "Крабовый"});
            this.listBox_salad.Location = new System.Drawing.Point(198, 66);
            this.listBox_salad.Name = "listBox_salad";
            this.listBox_salad.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_salad.Size = new System.Drawing.Size(186, 84);
            this.listBox_salad.TabIndex = 6;
            // 
            // listBox_dessert
            // 
            this.listBox_dessert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_dessert.FormattingEnabled = true;
            this.listBox_dessert.ItemHeight = 20;
            this.listBox_dessert.Items.AddRange(new object[] {
            "Чизкейк",
            "Штрудель",
            "Тирамису"});
            this.listBox_dessert.Location = new System.Drawing.Point(399, 66);
            this.listBox_dessert.Name = "listBox_dessert";
            this.listBox_dessert.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_dessert.Size = new System.Drawing.Size(104, 64);
            this.listBox_dessert.TabIndex = 7;
            // 
            // label_drink
            // 
            this.label_drink.AutoSize = true;
            this.label_drink.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_drink.Location = new System.Drawing.Point(523, 19);
            this.label_drink.Name = "label_drink";
            this.label_drink.Size = new System.Drawing.Size(96, 25);
            this.label_drink.TabIndex = 8;
            this.label_drink.Text = "Напитки";
            // 
            // listBox_drink
            // 
            this.listBox_drink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_drink.FormattingEnabled = true;
            this.listBox_drink.ItemHeight = 20;
            this.listBox_drink.Items.AddRange(new object[] {
            "Кофе",
            "Чай"});
            this.listBox_drink.Location = new System.Drawing.Point(528, 66);
            this.listBox_drink.Name = "listBox_drink";
            this.listBox_drink.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_drink.Size = new System.Drawing.Size(104, 64);
            this.listBox_drink.TabIndex = 9;
            // 
            // label_sauce
            // 
            this.label_sauce.AutoSize = true;
            this.label_sauce.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_sauce.Location = new System.Drawing.Point(659, 19);
            this.label_sauce.Name = "label_sauce";
            this.label_sauce.Size = new System.Drawing.Size(76, 25);
            this.label_sauce.TabIndex = 10;
            this.label_sauce.Text = "Соусы";
            // 
            // listBox_sause
            // 
            this.listBox_sause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_sause.FormattingEnabled = true;
            this.listBox_sause.ItemHeight = 20;
            this.listBox_sause.Items.AddRange(new object[] {
            "Барбекю",
            "Шашлычный",
            "Татарский",
            "Острый"});
            this.listBox_sause.Location = new System.Drawing.Point(651, 66);
            this.listBox_sause.Name = "listBox_sause";
            this.listBox_sause.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_sause.Size = new System.Drawing.Size(116, 84);
            this.listBox_sause.TabIndex = 11;
            // 
            // label_jam
            // 
            this.label_jam.AutoSize = true;
            this.label_jam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_jam.Location = new System.Drawing.Point(34, 275);
            this.label_jam.Name = "label_jam";
            this.label_jam.Size = new System.Drawing.Size(85, 25);
            this.label_jam.TabIndex = 12;
            this.label_jam.Text = "Джемы";
            // 
            // listBox_jam
            // 
            this.listBox_jam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_jam.FormattingEnabled = true;
            this.listBox_jam.ItemHeight = 20;
            this.listBox_jam.Items.AddRange(new object[] {
            "Абрикосовый ",
            "Малиновый"});
            this.listBox_jam.Location = new System.Drawing.Point(29, 314);
            this.listBox_jam.Name = "listBox_jam";
            this.listBox_jam.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_jam.Size = new System.Drawing.Size(110, 64);
            this.listBox_jam.TabIndex = 13;
            // 
            // textBox_first_dish
            // 
            this.textBox_first_dish.Location = new System.Drawing.Point(39, 172);
            this.textBox_first_dish.Name = "textBox_first_dish";
            this.textBox_first_dish.Size = new System.Drawing.Size(100, 20);
            this.textBox_first_dish.TabIndex = 14;
            this.textBox_first_dish.TextChanged += new System.EventHandler(this.textBox_first_dish_TextChanged);
            // 
            // textBox_salad
            // 
            this.textBox_salad.Location = new System.Drawing.Point(245, 174);
            this.textBox_salad.Name = "textBox_salad";
            this.textBox_salad.Size = new System.Drawing.Size(100, 20);
            this.textBox_salad.TabIndex = 15;
            // 
            // textBox_desserts
            // 
            this.textBox_desserts.Location = new System.Drawing.Point(399, 168);
            this.textBox_desserts.Name = "textBox_desserts";
            this.textBox_desserts.Size = new System.Drawing.Size(100, 20);
            this.textBox_desserts.TabIndex = 16;
            // 
            // textBox_drink
            // 
            this.textBox_drink.Location = new System.Drawing.Point(528, 168);
            this.textBox_drink.Name = "textBox_drink";
            this.textBox_drink.Size = new System.Drawing.Size(100, 20);
            this.textBox_drink.TabIndex = 17;
            // 
            // textBox_sause
            // 
            this.textBox_sause.Location = new System.Drawing.Point(664, 174);
            this.textBox_sause.Name = "textBox_sause";
            this.textBox_sause.Size = new System.Drawing.Size(100, 20);
            this.textBox_sause.TabIndex = 18;
            // 
            // textBox_jam
            // 
            this.textBox_jam.Location = new System.Drawing.Point(42, 409);
            this.textBox_jam.Name = "textBox_jam";
            this.textBox_jam.Size = new System.Drawing.Size(100, 20);
            this.textBox_jam.TabIndex = 19;
            // 
            // label_price_first
            // 
            this.label_price_first.AutoSize = true;
            this.label_price_first.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_price_first.Location = new System.Drawing.Point(71, 205);
            this.label_price_first.Name = "label_price_first";
            this.label_price_first.Size = new System.Drawing.Size(48, 20);
            this.label_price_first.TabIndex = 20;
            this.label_price_first.Text = "Цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(250, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Количество:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(45, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Количество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(45, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Количество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(409, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Количество:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(534, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Количество:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(661, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Количество:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_price_first);
            this.Controls.Add(this.textBox_jam);
            this.Controls.Add(this.textBox_sause);
            this.Controls.Add(this.textBox_drink);
            this.Controls.Add(this.textBox_desserts);
            this.Controls.Add(this.textBox_salad);
            this.Controls.Add(this.textBox_first_dish);
            this.Controls.Add(this.listBox_jam);
            this.Controls.Add(this.label_jam);
            this.Controls.Add(this.listBox_sause);
            this.Controls.Add(this.label_sauce);
            this.Controls.Add(this.listBox_drink);
            this.Controls.Add(this.label_drink);
            this.Controls.Add(this.listBox_dessert);
            this.Controls.Add(this.listBox_salad);
            this.Controls.Add(this.listBox_first_dish);
            this.Controls.Add(this.label_dessert);
            this.Controls.Add(this.label_salad);
            this.Controls.Add(this.label_first_dish);
            this.Name = "Form1";
            this.Text = "Меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_first_dish;
        private System.Windows.Forms.Label label_salad;
        private System.Windows.Forms.Label label_dessert;
        private System.Windows.Forms.ListBox listBox_first_dish;
        private System.Windows.Forms.ListBox listBox_salad;
        private System.Windows.Forms.ListBox listBox_dessert;
        private System.Windows.Forms.Label label_drink;
        private System.Windows.Forms.ListBox listBox_drink;
        private System.Windows.Forms.Label label_sauce;
        private System.Windows.Forms.ListBox listBox_sause;
        private System.Windows.Forms.Label label_jam;
        private System.Windows.Forms.ListBox listBox_jam;
        private System.Windows.Forms.TextBox textBox_first_dish;
        private System.Windows.Forms.TextBox textBox_salad;
        private System.Windows.Forms.TextBox textBox_desserts;
        private System.Windows.Forms.TextBox textBox_drink;
        private System.Windows.Forms.TextBox textBox_sause;
        private System.Windows.Forms.TextBox textBox_jam;
        private System.Windows.Forms.Label label_price_first;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

