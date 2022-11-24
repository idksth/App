
namespace WindowsFormsApp1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаАвтомобильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаВодительToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаНарушениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаДокументыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходнойДокумент1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходнойДокумент2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(422, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицаАвтомобильToolStripMenuItem,
            this.таблицаВодительToolStripMenuItem,
            this.таблицаНарушениеToolStripMenuItem,
            this.таблицаДокументыToolStripMenuItem,
            this.таблицаToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 20);
            this.toolStripMenuItem1.Text = "Таблицы";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.удалениеToolStripMenuItem,
            this.toolStripMenuItem6});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(68, 20);
            this.toolStripMenuItem2.Text = "Запросы";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItem3.Text = "Выход";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // таблицаАвтомобильToolStripMenuItem
            // 
            this.таблицаАвтомобильToolStripMenuItem.Name = "таблицаАвтомобильToolStripMenuItem";
            this.таблицаАвтомобильToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.таблицаАвтомобильToolStripMenuItem.Text = "Таблица Автомобиль";
            this.таблицаАвтомобильToolStripMenuItem.Click += new System.EventHandler(this.таблицаАвтомобильToolStripMenuItem_Click);
            // 
            // таблицаВодительToolStripMenuItem
            // 
            this.таблицаВодительToolStripMenuItem.Name = "таблицаВодительToolStripMenuItem";
            this.таблицаВодительToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.таблицаВодительToolStripMenuItem.Text = "Таблица Водитель";
            // 
            // таблицаНарушениеToolStripMenuItem
            // 
            this.таблицаНарушениеToolStripMenuItem.Name = "таблицаНарушениеToolStripMenuItem";
            this.таблицаНарушениеToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.таблицаНарушениеToolStripMenuItem.Text = "Таблица Нарушение";
            // 
            // таблицаДокументыToolStripMenuItem
            // 
            this.таблицаДокументыToolStripMenuItem.Name = "таблицаДокументыToolStripMenuItem";
            this.таблицаДокументыToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.таблицаДокументыToolStripMenuItem.Text = "Таблица Документы";
            // 
            // таблицаToolStripMenuItem
            // 
            this.таблицаToolStripMenuItem.Name = "таблицаToolStripMenuItem";
            this.таблицаToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.таблицаToolStripMenuItem.Text = "Таблица Протокол ";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItem4.Text = "Добавление";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItem5.Text = "Изменение";
            // 
            // удалениеToolStripMenuItem
            // 
            this.удалениеToolStripMenuItem.Name = "удалениеToolStripMenuItem";
            this.удалениеToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.удалениеToolStripMenuItem.Text = "Удаление";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходнойДокумент1ToolStripMenuItem,
            this.выходнойДокумент2ToolStripMenuItem});
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItem6.Text = "Выходные документы";
            // 
            // выходнойДокумент1ToolStripMenuItem
            // 
            this.выходнойДокумент1ToolStripMenuItem.Name = "выходнойДокумент1ToolStripMenuItem";
            this.выходнойДокумент1ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.выходнойДокумент1ToolStripMenuItem.Text = "Выходной документ 1";
            // 
            // выходнойДокумент2ToolStripMenuItem
            // 
            this.выходнойДокумент2ToolStripMenuItem.Name = "выходнойДокумент2ToolStripMenuItem";
            this.выходнойДокумент2ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.выходнойДокумент2ToolStripMenuItem.Text = "Выходной документ 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(422, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Главное окно";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem таблицаАвтомобильToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаВодительToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem таблицаНарушениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаДокументыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem удалениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem выходнойДокумент1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходнойДокумент2ToolStripMenuItem;
    }
}

