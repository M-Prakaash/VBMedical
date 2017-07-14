<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class surveyorpart1
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
        Me.components = New System.ComponentModel.Container
        Dim Serial_NoLabel As System.Windows.Forms.Label
        Dim Place_of_SurveyLabel As System.Windows.Forms.Label
        Dim Area_CodeLabel As System.Windows.Forms.Label
        Dim Date_of_SurveyLabel As System.Windows.Forms.Label
        Dim Name_of_the_BlockLabel As System.Windows.Forms.Label
        Dim House_NumberLabel As System.Windows.Forms.Label
        Dim Road_nameLabel As System.Windows.Forms.Label
        Dim Name_of_headLabel As System.Windows.Forms.Label
        Dim TelephoneLabel As System.Windows.Forms.Label
        Dim MobileLabel As System.Windows.Forms.Label
        Dim Name_of_respondentLabel As System.Windows.Forms.Label
        Dim Relation_to_headLabel As System.Windows.Forms.Label
        Me.Surveyor1editedDataSet = New WindowsApplication1.surveyor1editedDataSet
        Me.Copy_of_Surveytable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Copy_of_Surveytable1TableAdapter = New WindowsApplication1.surveyor1editedDataSetTableAdapters.Copy_of_Surveytable1TableAdapter
        Me.TableAdapterManager = New WindowsApplication1.surveyor1editedDataSetTableAdapters.TableAdapterManager
        Me.Button1 = New System.Windows.Forms.Button
        Me.Serial_NoTextBox = New System.Windows.Forms.TextBox
        Me.Place_of_SurveyTextBox1 = New System.Windows.Forms.TextBox
        Me.Area_CodeTextBox = New System.Windows.Forms.TextBox
        Me.Date_of_SurveyDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Name_of_the_BlockTextBox = New System.Windows.Forms.TextBox
        Me.House_NumberTextBox = New System.Windows.Forms.TextBox
        Me.Road_nameTextBox = New System.Windows.Forms.TextBox
        Me.Name_of_headTextBox = New System.Windows.Forms.TextBox
        Me.TelephoneTextBox = New System.Windows.Forms.TextBox
        Me.MobileTextBox = New System.Windows.Forms.TextBox
        Me.Name_of_respondentTextBox = New System.Windows.Forms.TextBox
        Me.Relation_to_headTextBox = New System.Windows.Forms.TextBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.Button2 = New System.Windows.Forms.Button
        Me.Copy_of_Surveytable1DataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Serial_NoLabel = New System.Windows.Forms.Label
        Place_of_SurveyLabel = New System.Windows.Forms.Label
        Area_CodeLabel = New System.Windows.Forms.Label
        Date_of_SurveyLabel = New System.Windows.Forms.Label
        Name_of_the_BlockLabel = New System.Windows.Forms.Label
        House_NumberLabel = New System.Windows.Forms.Label
        Road_nameLabel = New System.Windows.Forms.Label
        Name_of_headLabel = New System.Windows.Forms.Label
        TelephoneLabel = New System.Windows.Forms.Label
        MobileLabel = New System.Windows.Forms.Label
        Name_of_respondentLabel = New System.Windows.Forms.Label
        Relation_to_headLabel = New System.Windows.Forms.Label
        CType(Me.Surveyor1editedDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Copy_of_Surveytable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Copy_of_Surveytable1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Serial_NoLabel
        '
        Serial_NoLabel.AutoSize = True
        Serial_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Serial_NoLabel.Location = New System.Drawing.Point(73, 49)
        Serial_NoLabel.Name = "Serial_NoLabel"
        Serial_NoLabel.Size = New System.Drawing.Size(89, 22)
        Serial_NoLabel.TabIndex = 30
        Serial_NoLabel.Text = "Serial No:"
        '
        'Place_of_SurveyLabel
        '
        Place_of_SurveyLabel.AutoSize = True
        Place_of_SurveyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Place_of_SurveyLabel.Location = New System.Drawing.Point(73, 91)
        Place_of_SurveyLabel.Name = "Place_of_SurveyLabel"
        Place_of_SurveyLabel.Size = New System.Drawing.Size(141, 22)
        Place_of_SurveyLabel.TabIndex = 32
        Place_of_SurveyLabel.Text = "Place of Survey:"
        '
        'Area_CodeLabel
        '
        Area_CodeLabel.AutoSize = True
        Area_CodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Area_CodeLabel.Location = New System.Drawing.Point(72, 136)
        Area_CodeLabel.Name = "Area_CodeLabel"
        Area_CodeLabel.Size = New System.Drawing.Size(101, 22)
        Area_CodeLabel.TabIndex = 34
        Area_CodeLabel.Text = "Area Code:"
        '
        'Date_of_SurveyLabel
        '
        Date_of_SurveyLabel.AutoSize = True
        Date_of_SurveyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_of_SurveyLabel.Location = New System.Drawing.Point(72, 186)
        Date_of_SurveyLabel.Name = "Date_of_SurveyLabel"
        Date_of_SurveyLabel.Size = New System.Drawing.Size(134, 22)
        Date_of_SurveyLabel.TabIndex = 36
        Date_of_SurveyLabel.Text = "Date of Survey:"
        '
        'Name_of_the_BlockLabel
        '
        Name_of_the_BlockLabel.AutoSize = True
        Name_of_the_BlockLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Name_of_the_BlockLabel.Location = New System.Drawing.Point(72, 232)
        Name_of_the_BlockLabel.Name = "Name_of_the_BlockLabel"
        Name_of_the_BlockLabel.Size = New System.Drawing.Size(161, 22)
        Name_of_the_BlockLabel.TabIndex = 38
        Name_of_the_BlockLabel.Text = "Name of the Block:"
        '
        'House_NumberLabel
        '
        House_NumberLabel.AutoSize = True
        House_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        House_NumberLabel.Location = New System.Drawing.Point(73, 285)
        House_NumberLabel.Name = "House_NumberLabel"
        House_NumberLabel.Size = New System.Drawing.Size(135, 22)
        House_NumberLabel.TabIndex = 40
        House_NumberLabel.Text = "House Number:"
        '
        'Road_nameLabel
        '
        Road_nameLabel.AutoSize = True
        Road_nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Road_nameLabel.Location = New System.Drawing.Point(72, 339)
        Road_nameLabel.Name = "Road_nameLabel"
        Road_nameLabel.Size = New System.Drawing.Size(107, 22)
        Road_nameLabel.TabIndex = 42
        Road_nameLabel.Text = "Road name:"
        '
        'Name_of_headLabel
        '
        Name_of_headLabel.AutoSize = True
        Name_of_headLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Name_of_headLabel.Location = New System.Drawing.Point(72, 391)
        Name_of_headLabel.Name = "Name_of_headLabel"
        Name_of_headLabel.Size = New System.Drawing.Size(127, 22)
        Name_of_headLabel.TabIndex = 44
        Name_of_headLabel.Text = "Name of head:"
        '
        'TelephoneLabel
        '
        TelephoneLabel.AutoSize = True
        TelephoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelephoneLabel.Location = New System.Drawing.Point(73, 442)
        TelephoneLabel.Name = "TelephoneLabel"
        TelephoneLabel.Size = New System.Drawing.Size(101, 22)
        TelephoneLabel.TabIndex = 46
        TelephoneLabel.Text = "Telephone:"
        '
        'MobileLabel
        '
        MobileLabel.AutoSize = True
        MobileLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MobileLabel.Location = New System.Drawing.Point(73, 492)
        MobileLabel.Name = "MobileLabel"
        MobileLabel.Size = New System.Drawing.Size(67, 22)
        MobileLabel.TabIndex = 48
        MobileLabel.Text = "Mobile:"
        '
        'Name_of_respondentLabel
        '
        Name_of_respondentLabel.AutoSize = True
        Name_of_respondentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Name_of_respondentLabel.Location = New System.Drawing.Point(73, 539)
        Name_of_respondentLabel.Name = "Name_of_respondentLabel"
        Name_of_respondentLabel.Size = New System.Drawing.Size(177, 22)
        Name_of_respondentLabel.TabIndex = 50
        Name_of_respondentLabel.Text = "Name of respondent:"
        '
        'Relation_to_headLabel
        '
        Relation_to_headLabel.AutoSize = True
        Relation_to_headLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Relation_to_headLabel.Location = New System.Drawing.Point(72, 594)
        Relation_to_headLabel.Name = "Relation_to_headLabel"
        Relation_to_headLabel.Size = New System.Drawing.Size(146, 22)
        Relation_to_headLabel.TabIndex = 52
        Relation_to_headLabel.Text = "Relation to head:"
        '
        'Surveyor1editedDataSet
        '
        Me.Surveyor1editedDataSet.DataSetName = "surveyor1editedDataSet"
        Me.Surveyor1editedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Copy_of_Surveytable1BindingSource
        '
        Me.Copy_of_Surveytable1BindingSource.DataMember = "Copy of Surveytable1"
        Me.Copy_of_Surveytable1BindingSource.DataSource = Me.Surveyor1editedDataSet
        '
        'Copy_of_Surveytable1TableAdapter
        '
        Me.Copy_of_Surveytable1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Copy_of_Surveytable1TableAdapter = Me.Copy_of_Surveytable1TableAdapter
        Me.TableAdapterManager.Surveytable1TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.surveyor1editedDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(896, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 35)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "PREVIOUS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Serial_NoTextBox
        '
        Me.Serial_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Copy_of_Surveytable1BindingSource, "Serial No", True))
        Me.Serial_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Serial_NoTextBox.Location = New System.Drawing.Point(374, 46)
        Me.Serial_NoTextBox.Name = "Serial_NoTextBox"
        Me.Serial_NoTextBox.Size = New System.Drawing.Size(200, 27)
        Me.Serial_NoTextBox.TabIndex = 31
        '
        'Place_of_SurveyTextBox1
        '
        Me.Place_of_SurveyTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Copy_of_Surveytable1BindingSource, "Place of Survey", True))
        Me.Place_of_SurveyTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Place_of_SurveyTextBox1.Location = New System.Drawing.Point(805, 91)
        Me.Place_of_SurveyTextBox1.Name = "Place_of_SurveyTextBox1"
        Me.Place_of_SurveyTextBox1.Size = New System.Drawing.Size(200, 27)
        Me.Place_of_SurveyTextBox1.TabIndex = 33
        '
        'Area_CodeTextBox
        '
        Me.Area_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Copy_of_Surveytable1BindingSource, "Area Code", True))
        Me.Area_CodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Area_CodeTextBox.Location = New System.Drawing.Point(374, 136)
        Me.Area_CodeTextBox.Name = "Area_CodeTextBox"
        Me.Area_CodeTextBox.Size = New System.Drawing.Size(200, 27)
        Me.Area_CodeTextBox.TabIndex = 35
        '
        'Date_of_SurveyDateTimePicker
        '
        Me.Date_of_SurveyDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Copy_of_Surveytable1BindingSource, "Date of Survey", True))
        Me.Date_of_SurveyDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_of_SurveyDateTimePicker.Location = New System.Drawing.Point(374, 181)
        Me.Date_of_SurveyDateTimePicker.Name = "Date_of_SurveyDateTimePicker"
        Me.Date_of_SurveyDateTimePicker.Size = New System.Drawing.Size(200, 27)
        Me.Date_of_SurveyDateTimePicker.TabIndex = 37
        '
        'Name_of_the_BlockTextBox
        '
        Me.Name_of_the_BlockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Copy_of_Surveytable1BindingSource, "Name of the Block", True))
        Me.Name_of_the_BlockTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_of_the_BlockTextBox.Location = New System.Drawing.Point(374, 232)
        Me.Name_of_the_BlockTextBox.Name = "Name_of_the_BlockTextBox"
        Me.Name_of_the_BlockTextBox.Size = New System.Drawing.Size(200, 27)
        Me.Name_of_the_BlockTextBox.TabIndex = 39
        '
        'House_NumberTextBox
        '
        Me.House_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Copy_of_Surveytable1BindingSource, "House Number", True))
        Me.House_NumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.House_NumberTextBox.Location = New System.Drawing.Point(374, 285)
        Me.House_NumberTextBox.Name = "House_NumberTextBox"
        Me.House_NumberTextBox.Size = New System.Drawing.Size(200, 27)
        Me.House_NumberTextBox.TabIndex = 41
        '
        'Road_nameTextBox
        '
        Me.Road_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Copy_of_Surveytable1BindingSource, "road name", True))
        Me.Road_nameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Road_nameTextBox.Location = New System.Drawing.Point(374, 334)
        Me.Road_nameTextBox.Name = "Road_nameTextBox"
        Me.Road_nameTextBox.Size = New System.Drawing.Size(200, 27)
        Me.Road_nameTextBox.TabIndex = 43
        '
        'Name_of_headTextBox
        '
        Me.Name_of_headTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Copy_of_Surveytable1BindingSource, "name of head", True))
        Me.Name_of_headTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_of_headTextBox.Location = New System.Drawing.Point(374, 386)
        Me.Name_of_headTextBox.Name = "Name_of_headTextBox"
        Me.Name_of_headTextBox.Size = New System.Drawing.Size(200, 27)
        Me.Name_of_headTextBox.TabIndex = 45
        '
        'TelephoneTextBox
        '
        Me.TelephoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Copy_of_Surveytable1BindingSource, "telephone", True))
        Me.TelephoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelephoneTextBox.Location = New System.Drawing.Point(374, 437)
        Me.TelephoneTextBox.Name = "TelephoneTextBox"
        Me.TelephoneTextBox.Size = New System.Drawing.Size(200, 27)
        Me.TelephoneTextBox.TabIndex = 47
        '
        'MobileTextBox
        '
        Me.MobileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Copy_of_Surveytable1BindingSource, "mobile", True))
        Me.MobileTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobileTextBox.Location = New System.Drawing.Point(374, 492)
        Me.MobileTextBox.Name = "MobileTextBox"
        Me.MobileTextBox.Size = New System.Drawing.Size(200, 27)
        Me.MobileTextBox.TabIndex = 49
        '
        'Name_of_respondentTextBox
        '
        Me.Name_of_respondentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Copy_of_Surveytable1BindingSource, "name of respondent", True))
        Me.Name_of_respondentTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_of_respondentTextBox.Location = New System.Drawing.Point(374, 534)
        Me.Name_of_respondentTextBox.Name = "Name_of_respondentTextBox"
        Me.Name_of_respondentTextBox.Size = New System.Drawing.Size(200, 27)
        Me.Name_of_respondentTextBox.TabIndex = 51
        '
        'Relation_to_headTextBox
        '
        Me.Relation_to_headTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Copy_of_Surveytable1BindingSource, "relation to head", True))
        Me.Relation_to_headTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Relation_to_headTextBox.Location = New System.Drawing.Point(374, 589)
        Me.Relation_to_headTextBox.Name = "Relation_to_headTextBox"
        Me.Relation_to_headTextBox.Size = New System.Drawing.Size(200, 27)
        Me.Relation_to_headTextBox.TabIndex = 53
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(374, 91)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(77, 26)
        Me.RadioButton1.TabIndex = 54
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Urban"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(584, 91)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(71, 26)
        Me.RadioButton2.TabIndex = 55
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Rural"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(896, 594)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 37)
        Me.Button2.TabIndex = 56
        Me.Button2.Text = "NEXT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Copy_of_Surveytable1DataGridView
        '
        Me.Copy_of_Surveytable1DataGridView.AutoGenerateColumns = False
        Me.Copy_of_Surveytable1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Copy_of_Surveytable1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.Copy_of_Surveytable1DataGridView.DataSource = Me.Copy_of_Surveytable1BindingSource
        Me.Copy_of_Surveytable1DataGridView.Location = New System.Drawing.Point(12, 657)
        Me.Copy_of_Surveytable1DataGridView.Name = "Copy_of_Surveytable1DataGridView"
        Me.Copy_of_Surveytable1DataGridView.Size = New System.Drawing.Size(1021, 180)
        Me.Copy_of_Surveytable1DataGridView.TabIndex = 56
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Serial No"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Serial No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Place of Survey"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Place of Survey"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Area Code"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Area Code"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Date of Survey"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Date of Survey"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Name of the Block"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Name of the Block"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "House Number"
        Me.DataGridViewTextBoxColumn6.HeaderText = "House Number"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "road name"
        Me.DataGridViewTextBoxColumn7.HeaderText = "road name"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "name of head"
        Me.DataGridViewTextBoxColumn8.HeaderText = "name of head"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "telephone"
        Me.DataGridViewTextBoxColumn9.HeaderText = "telephone"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "mobile"
        Me.DataGridViewTextBoxColumn10.HeaderText = "mobile"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "name of respondent"
        Me.DataGridViewTextBoxColumn11.HeaderText = "name of respondent"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "relation to head"
        Me.DataGridViewTextBoxColumn12.HeaderText = "relation to head"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'surveyorpart1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1070, 849)
        Me.Controls.Add(Me.Copy_of_Surveytable1DataGridView)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Serial_NoLabel)
        Me.Controls.Add(Me.Serial_NoTextBox)
        Me.Controls.Add(Place_of_SurveyLabel)
        Me.Controls.Add(Me.Place_of_SurveyTextBox1)
        Me.Controls.Add(Area_CodeLabel)
        Me.Controls.Add(Me.Area_CodeTextBox)
        Me.Controls.Add(Date_of_SurveyLabel)
        Me.Controls.Add(Me.Date_of_SurveyDateTimePicker)
        Me.Controls.Add(Name_of_the_BlockLabel)
        Me.Controls.Add(Me.Name_of_the_BlockTextBox)
        Me.Controls.Add(House_NumberLabel)
        Me.Controls.Add(Me.House_NumberTextBox)
        Me.Controls.Add(Road_nameLabel)
        Me.Controls.Add(Me.Road_nameTextBox)
        Me.Controls.Add(Name_of_headLabel)
        Me.Controls.Add(Me.Name_of_headTextBox)
        Me.Controls.Add(TelephoneLabel)
        Me.Controls.Add(Me.TelephoneTextBox)
        Me.Controls.Add(MobileLabel)
        Me.Controls.Add(Me.MobileTextBox)
        Me.Controls.Add(Name_of_respondentLabel)
        Me.Controls.Add(Me.Name_of_respondentTextBox)
        Me.Controls.Add(Relation_to_headLabel)
        Me.Controls.Add(Me.Relation_to_headTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Name = "surveyorpart1"
        Me.Text = "surveyorpart1"
        CType(Me.Surveyor1editedDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Copy_of_Surveytable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Copy_of_Surveytable1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Surveyor1editedDataSet As WindowsApplication1.surveyor1editedDataSet
    Friend WithEvents Copy_of_Surveytable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Copy_of_Surveytable1TableAdapter As WindowsApplication1.surveyor1editedDataSetTableAdapters.Copy_of_Surveytable1TableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.surveyor1editedDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Serial_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Place_of_SurveyTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Area_CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_of_SurveyDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Name_of_the_BlockTextBox As System.Windows.Forms.TextBox
    Friend WithEvents House_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Road_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Name_of_headTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelephoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MobileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Name_of_respondentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Relation_to_headTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Copy_of_Surveytable1DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
