﻿namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обменДаннымиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортВФРБToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортВФБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяРаботыСФБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.базаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.формыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.формаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.формаCOWMILKPRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.интеграцияСBLUPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запускИнтеграцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.версияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контактыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программаToolStripMenuItem,
            this.обменДаннымиToolStripMenuItem,
            this.базаДанныхToolStripMenuItem,
            this.формыToolStripMenuItem,
            this.интеграцияСBLUPToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(740, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // программаToolStripMenuItem
            // 
            this.программаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.программаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            this.программаToolStripMenuItem.Size = new System.Drawing.Size(113, 25);
            this.программаToolStripMenuItem.Text = "Программа";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // обменДаннымиToolStripMenuItem
            // 
            this.обменДаннымиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.экспортВФРБToolStripMenuItem,
            this.импортВФБДToolStripMenuItem,
            this.историяРаботыСФБДToolStripMenuItem});
            this.обменДаннымиToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.обменДаннымиToolStripMenuItem.Name = "обменДаннымиToolStripMenuItem";
            this.обменДаннымиToolStripMenuItem.Size = new System.Drawing.Size(153, 25);
            this.обменДаннымиToolStripMenuItem.Text = "Обмен данными";
            // 
            // экспортВФРБToolStripMenuItem
            // 
            this.экспортВФРБToolStripMenuItem.Name = "экспортВФРБToolStripMenuItem";
            this.экспортВФРБToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.экспортВФРБToolStripMenuItem.Text = "Экспорт в ФБД";
            this.экспортВФРБToolStripMenuItem.Click += new System.EventHandler(this.экспортВФРБToolStripMenuItem_Click);
            // 
            // импортВФБДToolStripMenuItem
            // 
            this.импортВФБДToolStripMenuItem.Name = "импортВФБДToolStripMenuItem";
            this.импортВФБДToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.импортВФБДToolStripMenuItem.Text = "Импорт в ФБД";
            this.импортВФБДToolStripMenuItem.Click += new System.EventHandler(this.импортВФБДToolStripMenuItem_Click);
            // 
            // историяРаботыСФБДToolStripMenuItem
            // 
            this.историяРаботыСФБДToolStripMenuItem.Name = "историяРаботыСФБДToolStripMenuItem";
            this.историяРаботыСФБДToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.историяРаботыСФБДToolStripMenuItem.Text = "История работы с ФБД";
            // 
            // базаДанныхToolStripMenuItem
            // 
            this.базаДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкаToolStripMenuItem,
            this.сохранениеToolStripMenuItem});
            this.базаДанныхToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.базаДанныхToolStripMenuItem.Name = "базаДанныхToolStripMenuItem";
            this.базаДанныхToolStripMenuItem.Size = new System.Drawing.Size(123, 25);
            this.базаДанныхToolStripMenuItem.Text = "База данных";
            // 
            // настройкаToolStripMenuItem
            // 
            this.настройкаToolStripMenuItem.Name = "настройкаToolStripMenuItem";
            this.настройкаToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.настройкаToolStripMenuItem.Text = "Настройка";
            this.настройкаToolStripMenuItem.Click += new System.EventHandler(this.настройкаToolStripMenuItem_Click);
            // 
            // сохранениеToolStripMenuItem
            // 
            this.сохранениеToolStripMenuItem.Name = "сохранениеToolStripMenuItem";
            this.сохранениеToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.сохранениеToolStripMenuItem.Text = "Сохранение";
            // 
            // формыToolStripMenuItem
            // 
            this.формыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.формаToolStripMenuItem,
            this.формаCOWMILKPRToolStripMenuItem});
            this.формыToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.формыToolStripMenuItem.Name = "формыToolStripMenuItem";
            this.формыToolStripMenuItem.Size = new System.Drawing.Size(80, 25);
            this.формыToolStripMenuItem.Text = "Формы";
            // 
            // формаToolStripMenuItem
            // 
            this.формаToolStripMenuItem.Name = "формаToolStripMenuItem";
            this.формаToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.формаToolStripMenuItem.Text = "Форма  COWMILK";
            this.формаToolStripMenuItem.Click += new System.EventHandler(this.формаToolStripMenuItem_Click);
            // 
            // формаCOWMILKPRToolStripMenuItem
            // 
            this.формаCOWMILKPRToolStripMenuItem.Name = "формаCOWMILKPRToolStripMenuItem";
            this.формаCOWMILKPRToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.формаCOWMILKPRToolStripMenuItem.Text = "Форма COWMILK_PR";
            this.формаCOWMILKPRToolStripMenuItem.Click += new System.EventHandler(this.формаCOWMILKPRToolStripMenuItem_Click);
            // 
            // интеграцияСBLUPToolStripMenuItem
            // 
            this.интеграцияСBLUPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проверкаДанныхToolStripMenuItem,
            this.запускИнтеграцииToolStripMenuItem});
            this.интеграцияСBLUPToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.интеграцияСBLUPToolStripMenuItem.Name = "интеграцияСBLUPToolStripMenuItem";
            this.интеграцияСBLUPToolStripMenuItem.Size = new System.Drawing.Size(172, 25);
            this.интеграцияСBLUPToolStripMenuItem.Text = "Интеграция с BLUP";
            // 
            // проверкаДанныхToolStripMenuItem
            // 
            this.проверкаДанныхToolStripMenuItem.Name = "проверкаДанныхToolStripMenuItem";
            this.проверкаДанныхToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.проверкаДанныхToolStripMenuItem.Text = "Проверка данных";
            // 
            // запускИнтеграцииToolStripMenuItem
            // 
            this.запускИнтеграцииToolStripMenuItem.Name = "запускИнтеграцииToolStripMenuItem";
            this.запускИнтеграцииToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.запускИнтеграцииToolStripMenuItem.Text = "Запуск интеграции";
            this.запускИнтеграцииToolStripMenuItem.Click += new System.EventHandler(this.запускИнтеграцииToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.авторToolStripMenuItem,
            this.версияToolStripMenuItem,
            this.контактыToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(127, 25);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // авторToolStripMenuItem
            // 
            this.авторToolStripMenuItem.Name = "авторToolStripMenuItem";
            this.авторToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.авторToolStripMenuItem.Text = "Автор";
            // 
            // версияToolStripMenuItem
            // 
            this.версияToolStripMenuItem.Name = "версияToolStripMenuItem";
            this.версияToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.версияToolStripMenuItem.Text = "Версия";
            // 
            // контактыToolStripMenuItem
            // 
            this.контактыToolStripMenuItem.Name = "контактыToolStripMenuItem";
            this.контактыToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.контактыToolStripMenuItem.Text = "Контакты";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(740, 366);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Модуль расчета племенной ценности методом BLUP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обменДаннымиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортВФРБToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem базаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem формыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem интеграцияСBLUPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортВФБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяРаботыСФБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem формаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem формаCOWMILKPRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверкаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запускИнтеграцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem версияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контактыToolStripMenuItem;
    }
}

