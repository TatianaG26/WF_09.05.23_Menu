namespace WF_09._05._23_Menu
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.вставитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tSB_Open_file = new System.Windows.Forms.ToolStripButton();
            this.tSB_Save_file = new System.Windows.Forms.ToolStripButton();
            this.tSB_add_file = new System.Windows.Forms.ToolStripButton();
            this.tSB_Copy = new System.Windows.Forms.ToolStripButton();
            this.tSB_Cut = new System.Windows.Forms.ToolStripButton();
            this.tSB_Paste = new System.Windows.Forms.ToolStripButton();
            this.tSDDB_text_edit = new System.Windows.Forms.ToolStripDropDownButton();
            this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветФонаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ОткрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйДокументToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиТекстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветШрифтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветФонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem1,
            this.вырезатьToolStripMenuItem1,
            this.toolStripSeparator1,
            this.вставитьToolStripMenuItem1});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(214, 110);
            // 
            // копироватьToolStripMenuItem1
            // 
            this.копироватьToolStripMenuItem1.Name = "копироватьToolStripMenuItem1";
            this.копироватьToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.копироватьToolStripMenuItem1.Size = new System.Drawing.Size(213, 24);
            this.копироватьToolStripMenuItem1.Text = "Копировать";
            this.копироватьToolStripMenuItem1.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // вырезатьToolStripMenuItem1
            // 
            this.вырезатьToolStripMenuItem1.Name = "вырезатьToolStripMenuItem1";
            this.вырезатьToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.вырезатьToolStripMenuItem1.Size = new System.Drawing.Size(213, 24);
            this.вырезатьToolStripMenuItem1.Text = "Вырезать";
            this.вырезатьToolStripMenuItem1.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // вставитьToolStripMenuItem1
            // 
            this.вставитьToolStripMenuItem1.Name = "вставитьToolStripMenuItem1";
            this.вставитьToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.вставитьToolStripMenuItem1.Size = new System.Drawing.Size(213, 24);
            this.вставитьToolStripMenuItem1.Text = "Вставить";
            this.вставитьToolStripMenuItem1.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSB_Open_file,
            this.tSB_Save_file,
            this.tSB_add_file,
            this.tSB_Copy,
            this.tSB_Cut,
            this.tSB_Paste,
            this.tSDDB_text_edit});
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(631, 27);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tSB_Open_file
            // 
            this.tSB_Open_file.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB_Open_file.Image = global::WF_09._05._23_Menu.Properties.Resources.free_icon_open_file_7604005;
            this.tSB_Open_file.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_Open_file.Name = "tSB_Open_file";
            this.tSB_Open_file.Size = new System.Drawing.Size(29, 24);
            this.tSB_Open_file.Text = "Открыть";
            this.tSB_Open_file.Click += new System.EventHandler(this.ОткрытьToolStripMenuItem_Click);
            // 
            // tSB_Save_file
            // 
            this.tSB_Save_file.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB_Save_file.Image = global::WF_09._05._23_Menu.Properties.Resources.free_icon_save_148730;
            this.tSB_Save_file.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_Save_file.Name = "tSB_Save_file";
            this.tSB_Save_file.Size = new System.Drawing.Size(29, 24);
            this.tSB_Save_file.Text = "Сохранить";
            this.tSB_Save_file.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // tSB_add_file
            // 
            this.tSB_add_file.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB_add_file.Image = global::WF_09._05._23_Menu.Properties.Resources.free_icon_add_file_1151197;
            this.tSB_add_file.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_add_file.Name = "tSB_add_file";
            this.tSB_add_file.Size = new System.Drawing.Size(29, 24);
            this.tSB_add_file.Text = "Новый документ";
            this.tSB_add_file.Click += new System.EventHandler(this.новыйДокументToolStripMenuItem_Click);
            // 
            // tSB_Copy
            // 
            this.tSB_Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB_Copy.Image = global::WF_09._05._23_Menu.Properties.Resources.free_icon_copy_3979470;
            this.tSB_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_Copy.Name = "tSB_Copy";
            this.tSB_Copy.Size = new System.Drawing.Size(29, 24);
            this.tSB_Copy.Text = "Копировать";
            this.tSB_Copy.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // tSB_Cut
            // 
            this.tSB_Cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB_Cut.Image = global::WF_09._05._23_Menu.Properties.Resources.free_icon_cut_8367520;
            this.tSB_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_Cut.Name = "tSB_Cut";
            this.tSB_Cut.Size = new System.Drawing.Size(29, 24);
            this.tSB_Cut.Text = "Вырезать";
            this.tSB_Cut.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
            // 
            // tSB_Paste
            // 
            this.tSB_Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB_Paste.Image = global::WF_09._05._23_Menu.Properties.Resources.free_icon_paste_1834036;
            this.tSB_Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_Paste.Name = "tSB_Paste";
            this.tSB_Paste.Size = new System.Drawing.Size(29, 24);
            this.tSB_Paste.Text = "Вставить";
            this.tSB_Paste.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // tSDDB_text_edit
            // 
            this.tSDDB_text_edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSDDB_text_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветToolStripMenuItem,
            this.цветФонаToolStripMenuItem1,
            this.шрифтToolStripMenuItem1});
            this.tSDDB_text_edit.Image = global::WF_09._05._23_Menu.Properties.Resources.free_icon_text_editor_6440443;
            this.tSDDB_text_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSDDB_text_edit.Name = "tSDDB_text_edit";
            this.tSDDB_text_edit.Size = new System.Drawing.Size(34, 24);
            this.tSDDB_text_edit.Text = "Настройка редактора";
            // 
            // цветToolStripMenuItem
            // 
            this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            this.цветToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.цветToolStripMenuItem.Text = "цвет шрифта";
            this.цветToolStripMenuItem.Click += new System.EventHandler(this.цветШрифтаToolStripMenuItem_Click);
            // 
            // цветФонаToolStripMenuItem1
            // 
            this.цветФонаToolStripMenuItem1.Name = "цветФонаToolStripMenuItem1";
            this.цветФонаToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.цветФонаToolStripMenuItem1.Text = "цвет фона";
            this.цветФонаToolStripMenuItem1.Click += new System.EventHandler(this.цветФонаToolStripMenuItem_Click);
            // 
            // шрифтToolStripMenuItem1
            // 
            this.шрифтToolStripMenuItem1.Name = "шрифтToolStripMenuItem1";
            this.шрифтToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.шрифтToolStripMenuItem1.Text = "шрифт";
            this.шрифтToolStripMenuItem1.Click += new System.EventHandler(this.шрифтToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.настройкиТекстаToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(631, 28);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ОткрытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.новыйДокументToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // ОткрытьToolStripMenuItem
            // 
            this.ОткрытьToolStripMenuItem.Image = global::WF_09._05._23_Menu.Properties.Resources.free_icon_open_file_7604005;
            this.ОткрытьToolStripMenuItem.Name = "ОткрытьToolStripMenuItem";
            this.ОткрытьToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ОткрытьToolStripMenuItem.Text = "Открыть";
            this.ОткрытьToolStripMenuItem.Click += new System.EventHandler(this.ОткрытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Image = global::WF_09._05._23_Menu.Properties.Resources.free_icon_save_148730;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // новыйДокументToolStripMenuItem
            // 
            this.новыйДокументToolStripMenuItem.Image = global::WF_09._05._23_Menu.Properties.Resources.free_icon_add_file_1151197;
            this.новыйДокументToolStripMenuItem.Name = "новыйДокументToolStripMenuItem";
            this.новыйДокументToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.новыйДокументToolStripMenuItem.Text = "Новый документ";
            this.новыйДокументToolStripMenuItem.Click += new System.EventHandler(this.новыйДокументToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.выделитьВсеToolStripMenuItem});
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Image = global::WF_09._05._23_Menu.Properties.Resources.free_icon_copy_3979470;
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Image = global::WF_09._05._23_Menu.Properties.Resources.free_icon_cut_8367520;
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Image = global::WF_09._05._23_Menu.Properties.Resources.free_icon_paste_1834036;
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // выделитьВсеToolStripMenuItem
            // 
            this.выделитьВсеToolStripMenuItem.Name = "выделитьВсеToolStripMenuItem";
            this.выделитьВсеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.выделитьВсеToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.выделитьВсеToolStripMenuItem.Text = "Выделить все";
            this.выделитьВсеToolStripMenuItem.Click += new System.EventHandler(this.выделитьВсеToolStripMenuItem_Click);
            // 
            // настройкиТекстаToolStripMenuItem
            // 
            this.настройкиТекстаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветШрифтаToolStripMenuItem,
            this.цветФонаToolStripMenuItem,
            this.шрифтToolStripMenuItem});
            this.настройкиТекстаToolStripMenuItem.Name = "настройкиТекстаToolStripMenuItem";
            this.настройкиТекстаToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.настройкиТекстаToolStripMenuItem.Text = "Настройки текста";
            // 
            // цветШрифтаToolStripMenuItem
            // 
            this.цветШрифтаToolStripMenuItem.Image = global::WF_09._05._23_Menu.Properties.Resources.free_icon_color_selection_3814930;
            this.цветШрифтаToolStripMenuItem.Name = "цветШрифтаToolStripMenuItem";
            this.цветШрифтаToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.цветШрифтаToolStripMenuItem.Text = "Цвет шрифта";
            this.цветШрифтаToolStripMenuItem.Click += new System.EventHandler(this.цветШрифтаToolStripMenuItem_Click);
            // 
            // цветФонаToolStripMenuItem
            // 
            this.цветФонаToolStripMenuItem.Image = global::WF_09._05._23_Menu.Properties.Resources.free_icon_color_selection_3815573;
            this.цветФонаToolStripMenuItem.Name = "цветФонаToolStripMenuItem";
            this.цветФонаToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.цветФонаToolStripMenuItem.Text = "Цвет фона";
            this.цветФонаToolStripMenuItem.Click += new System.EventHandler(this.цветФонаToolStripMenuItem_Click);
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.Image = global::WF_09._05._23_Menu.Properties.Resources.free_icon_font_32168;
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.шрифтToolStripMenuItem_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.ContextMenuStrip = this.contextMenuStrip;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(0, 55);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(631, 395);
            this.richTextBox.TabIndex = 5;
            this.richTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tSB_Open_file;
        private System.Windows.Forms.ToolStripButton tSB_Save_file;
        private System.Windows.Forms.ToolStripButton tSB_add_file;
        private System.Windows.Forms.ToolStripButton tSB_Copy;
        private System.Windows.Forms.ToolStripButton tSB_Cut;
        private System.Windows.Forms.ToolStripButton tSB_Paste;
        private System.Windows.Forms.ToolStripDropDownButton tSDDB_text_edit;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветФонаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ОткрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйДокументToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиТекстаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветШрифтаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветФонаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсеToolStripMenuItem;
    }
}

