namespace Parking
{
    partial class Parking
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parking));
            this.book = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.type_of_place = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gos_number = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.TextBox();
            this.hours = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cho_place = new System.Windows.Forms.Label();
            this.ty_place = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hours)).BeginInit();
            this.SuspendLayout();
            // 
            // book
            // 
            this.book.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.book.Location = new System.Drawing.Point(880, 484);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(290, 64);
            this.book.TabIndex = 1;
            this.book.Text = "Забронировать";
            this.book.UseVisualStyleBackColor = true;
            this.book.Click += new System.EventHandler(this.book_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добро пожаловать! Количество свободных мест:";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.c.Location = new System.Drawing.Point(880, 110);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(200, 30);
            this.c.TabIndex = 3;
            this.c.Text = "Выбранное место:";
            // 
            // type_of_place
            // 
            this.type_of_place.AutoSize = true;
            this.type_of_place.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.type_of_place.Location = new System.Drawing.Point(880, 149);
            this.type_of_place.Name = "type_of_place";
            this.type_of_place.Size = new System.Drawing.Size(119, 30);
            this.type_of_place.TabIndex = 4;
            this.type_of_place.Text = "Тип места:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(880, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Гос. номер вашей машины:";
            // 
            // gos_number
            // 
            this.gos_number.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gos_number.Location = new System.Drawing.Point(880, 255);
            this.gos_number.Name = "gos_number";
            this.gos_number.Size = new System.Drawing.Size(250, 36);
            this.gos_number.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(880, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Модель вашей машины:";
            // 
            // model
            // 
            this.model.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.model.Location = new System.Drawing.Point(880, 331);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(250, 36);
            this.model.TabIndex = 8;
            // 
            // hours
            // 
            this.hours.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hours.Location = new System.Drawing.Point(880, 407);
            this.hours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(97, 36);
            this.hours.TabIndex = 13;
            this.hours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(880, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "Кол-во часов:";
            // 
            // cho_place
            // 
            this.cho_place.AutoSize = true;
            this.cho_place.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cho_place.Location = new System.Drawing.Point(1075, 110);
            this.cho_place.Name = "cho_place";
            this.cho_place.Size = new System.Drawing.Size(0, 30);
            this.cho_place.TabIndex = 15;
            // 
            // ty_place
            // 
            this.ty_place.AutoSize = true;
            this.ty_place.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ty_place.Location = new System.Drawing.Point(996, 149);
            this.ty_place.Name = "ty_place";
            this.ty_place.Size = new System.Drawing.Size(0, 30);
            this.ty_place.TabIndex = 16;
            // 
            // Parking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 560);
            this.Controls.Add(this.ty_place);
            this.Controls.Add(this.cho_place);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.model);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gos_number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.type_of_place);
            this.Controls.Add(this.c);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.book);
            this.Name = "Parking";
            this.ShowIcon = false;
            this.Text = " Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.hours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button book;
        private Label label1;
        private Label c;
        private Label type_of_place;
        private Label label2;
        private TextBox gos_number;
        private Label label3;
        private TextBox model;
        private NumericUpDown hours;
        private Label label5;
        private Label cho_place;
        private Label ty_place;
    }
}