<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLittleLeague
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim Parent_Name_s_Label As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim Player_NumberLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Zip_CodeLabel As System.Windows.Forms.Label
        Dim Telephone_NumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLittleLeague))
        Me.LittleleagueDataSet = New SportsLeague.littleleagueDataSet()
        Me.TeamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeamTableAdapter = New SportsLeague.littleleagueDataSetTableAdapters.TeamTableAdapter()
        Me.TableAdapterManager = New SportsLeague.littleleagueDataSetTableAdapters.TableAdapterManager()
        Me.TeamBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.bnavDelete = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.bnavSave = New System.Windows.Forms.ToolStripButton()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Parent_Name_s_TextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Player_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Zip_CodeMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Telephone_NumberMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAges = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        Parent_Name_s_Label = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        Player_NumberLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Zip_CodeLabel = New System.Windows.Forms.Label()
        Telephone_NumberLabel = New System.Windows.Forms.Label()
        CType(Me.LittleleagueDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TeamBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(33, 219)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 3
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(32, 255)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 5
        Last_NameLabel.Text = "Last Name:"
        '
        'Parent_Name_s_Label
        '
        Parent_Name_s_Label.AutoSize = True
        Parent_Name_s_Label.Location = New System.Drawing.Point(10, 329)
        Parent_Name_s_Label.Name = "Parent_Name_s_Label"
        Parent_Name_s_Label.Size = New System.Drawing.Size(83, 13)
        Parent_Name_s_Label.TabIndex = 7
        Parent_Name_s_Label.Text = "Parent Name(s):"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(294, 219)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 11
        CityLabel.Text = "City:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(286, 255)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(35, 13)
        StateLabel.TabIndex = 13
        StateLabel.Text = "State:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(64, 291)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(29, 13)
        AgeLabel.TabIndex = 19
        AgeLabel.Text = "Age:"
        '
        'Player_NumberLabel
        '
        Player_NumberLabel.AutoSize = True
        Player_NumberLabel.Location = New System.Drawing.Point(14, 183)
        Player_NumberLabel.Name = "Player_NumberLabel"
        Player_NumberLabel.Size = New System.Drawing.Size(79, 13)
        Player_NumberLabel.TabIndex = 1
        Player_NumberLabel.Text = "Player Number:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(273, 183)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 9
        AddressLabel.Text = "Address:"
        '
        'Zip_CodeLabel
        '
        Zip_CodeLabel.AutoSize = True
        Zip_CodeLabel.Location = New System.Drawing.Point(267, 291)
        Zip_CodeLabel.Name = "Zip_CodeLabel"
        Zip_CodeLabel.Size = New System.Drawing.Size(53, 13)
        Zip_CodeLabel.TabIndex = 22
        Zip_CodeLabel.Text = "Zip Code:"
        '
        'Telephone_NumberLabel
        '
        Telephone_NumberLabel.AutoSize = True
        Telephone_NumberLabel.Location = New System.Drawing.Point(220, 329)
        Telephone_NumberLabel.Name = "Telephone_NumberLabel"
        Telephone_NumberLabel.Size = New System.Drawing.Size(101, 13)
        Telephone_NumberLabel.TabIndex = 23
        Telephone_NumberLabel.Text = "Telephone Number:"
        '
        'LittleleagueDataSet
        '
        Me.LittleleagueDataSet.DataSetName = "littleleagueDataSet"
        Me.LittleleagueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TeamBindingSource
        '
        Me.TeamBindingSource.DataMember = "Team"
        Me.TeamBindingSource.DataSource = Me.LittleleagueDataSet
        '
        'TeamTableAdapter
        '
        Me.TeamTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TeamTableAdapter = Me.TeamTableAdapter
        Me.TableAdapterManager.UpdateOrder = SportsLeague.littleleagueDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TeamBindingNavigator
        '
        Me.TeamBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TeamBindingNavigator.BindingSource = Me.TeamBindingSource
        Me.TeamBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TeamBindingNavigator.DeleteItem = Me.bnavDelete
        Me.TeamBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.bnavDelete, Me.bnavSave})
        Me.TeamBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TeamBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TeamBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TeamBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TeamBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TeamBindingNavigator.Name = "TeamBindingNavigator"
        Me.TeamBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TeamBindingNavigator.Size = New System.Drawing.Size(451, 25)
        Me.TeamBindingNavigator.TabIndex = 0
        Me.TeamBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'bnavDelete
        '
        Me.bnavDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnavDelete.Image = CType(resources.GetObject("bnavDelete.Image"), System.Drawing.Image)
        Me.bnavDelete.Name = "bnavDelete"
        Me.bnavDelete.RightToLeftAutoMirrorImage = True
        Me.bnavDelete.Size = New System.Drawing.Size(23, 22)
        Me.bnavDelete.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'bnavSave
        '
        Me.bnavSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnavSave.Image = CType(resources.GetObject("bnavSave.Image"), System.Drawing.Image)
        Me.bnavSave.Name = "bnavSave"
        Me.bnavSave.Size = New System.Drawing.Size(23, 22)
        Me.bnavSave.Text = "Save Data"
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "First Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(99, 216)
        Me.First_NameTextBox.MaxLength = 10
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.First_NameTextBox.TabIndex = 4
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(99, 252)
        Me.Last_NameTextBox.MaxLength = 20
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Last_NameTextBox.TabIndex = 6
        '
        'Parent_Name_s_TextBox
        '
        Me.Parent_Name_s_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "Parent Name(s)", True))
        Me.Parent_Name_s_TextBox.Location = New System.Drawing.Point(99, 324)
        Me.Parent_Name_s_TextBox.MaxLength = 28
        Me.Parent_Name_s_TextBox.Name = "Parent_Name_s_TextBox"
        Me.Parent_Name_s_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Parent_Name_s_TextBox.TabIndex = 8
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(326, 216)
        Me.CityTextBox.MaxLength = 28
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CityTextBox.TabIndex = 12
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "State", True))
        Me.StateTextBox.Location = New System.Drawing.Point(327, 252)
        Me.StateTextBox.MaxLength = 28
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StateTextBox.TabIndex = 14
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(99, 288)
        Me.AgeTextBox.MaxLength = 2
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AgeTextBox.TabIndex = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SportsLeague.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(228, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(23, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 40)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "National All-Stars " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Co-Ed Baseball" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Player_NumberTextBox
        '
        Me.Player_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "Player Number", True))
        Me.Player_NumberTextBox.Location = New System.Drawing.Point(99, 180)
        Me.Player_NumberTextBox.MaxLength = 28
        Me.Player_NumberTextBox.Name = "Player_NumberTextBox"
        Me.Player_NumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Player_NumberTextBox.TabIndex = 2
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(327, 180)
        Me.AddressTextBox.MaxLength = 28
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AddressTextBox.TabIndex = 10
        '
        'Zip_CodeMaskedTextBox
        '
        Me.Zip_CodeMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "Zip Code", True))
        Me.Zip_CodeMaskedTextBox.Location = New System.Drawing.Point(326, 288)
        Me.Zip_CodeMaskedTextBox.Mask = "00000"
        Me.Zip_CodeMaskedTextBox.Name = "Zip_CodeMaskedTextBox"
        Me.Zip_CodeMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Zip_CodeMaskedTextBox.TabIndex = 23
        '
        'Telephone_NumberMaskedTextBox
        '
        Me.Telephone_NumberMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "Telephone Number", True))
        Me.Telephone_NumberMaskedTextBox.Location = New System.Drawing.Point(326, 326)
        Me.Telephone_NumberMaskedTextBox.Mask = "000-0000"
        Me.Telephone_NumberMaskedTextBox.Name = "Telephone_NumberMaskedTextBox"
        Me.Telephone_NumberMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Telephone_NumberMaskedTextBox.TabIndex = 24
        '
        'btnAverage
        '
        Me.btnAverage.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAverage.Location = New System.Drawing.Point(309, 44)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(87, 23)
        Me.btnAverage.TabIndex = 25
        Me.btnAverage.Text = "Average Age"
        Me.btnAverage.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.lblAges)
        Me.Panel1.Location = New System.Drawing.Point(265, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(174, 85)
        Me.Panel1.TabIndex = 26
        '
        'lblAges
        '
        Me.lblAges.AutoSize = True
        Me.lblAges.Font = New System.Drawing.Font("Monospac821 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAges.Location = New System.Drawing.Point(-2, 4)
        Me.lblAges.Name = "lblAges"
        Me.lblAges.Size = New System.Drawing.Size(179, 76)
        Me.lblAges.TabIndex = 0
        Me.lblAges.Text = "12 Year Olds: 3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "13 Year Olds: 7" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "14 Year Olds: 4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Average Age: 12.3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmLittleLeague
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(451, 361)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAverage)
        Me.Controls.Add(Telephone_NumberLabel)
        Me.Controls.Add(Me.Telephone_NumberMaskedTextBox)
        Me.Controls.Add(Zip_CodeLabel)
        Me.Controls.Add(Me.Zip_CodeMaskedTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Parent_Name_s_Label)
        Me.Controls.Add(Me.Parent_Name_s_TextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Player_NumberLabel)
        Me.Controls.Add(Me.Player_NumberTextBox)
        Me.Controls.Add(Me.TeamBindingNavigator)
        Me.Name = "frmLittleLeague"
        Me.Text = "Sports League Baseball National All-Stars Co-ed Team Windows Application"
        CType(Me.LittleleagueDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TeamBindingNavigator.ResumeLayout(False)
        Me.TeamBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LittleleagueDataSet As SportsLeague.littleleagueDataSet
    Friend WithEvents TeamBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeamTableAdapter As SportsLeague.littleleagueDataSetTableAdapters.TeamTableAdapter
    Friend WithEvents TableAdapterManager As SportsLeague.littleleagueDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TeamBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents bnavDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bnavSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Parent_Name_s_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Player_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Zip_CodeMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Telephone_NumberMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnAverage As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblAges As System.Windows.Forms.Label

End Class
