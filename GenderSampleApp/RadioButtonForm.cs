using System.ComponentModel;
using GenderSampleApp.Classes;
using GenderSampleApp.Controls;
using GenderSampleApp.Models;

namespace GenderSampleApp;
public partial class RadioButtonForm : Form
{
    private BindingSource _peopleBindingSource = new BindingSource();
    private BindingList<Person> _peopleBindingList;
    public RadioButtonForm()
    {
        InitializeComponent();

        FemaleRadioButton.Tag = 1;
        MaleRadioButton.Tag = 2;
        OtherRadioButton.Tag = 3;

        GenderRadioGroupBox.SelectedChanged += GenderRadioGroupBox_SelectedChanged;

        _peopleBindingList = new BindingList<Person>(JsonHelper.DeserializePerson(File.ReadAllText("Mocked.json")));
        _peopleBindingSource.DataSource = _peopleBindingList;
        coreBindingNavigator1.RemoveAddRemove();
        coreBindingNavigator1.BindingSource = _peopleBindingSource;
        
        PrimaryKeyLabel.DataBindings.Add("Text", _peopleBindingSource, nameof(Person.Id));
        GenderRadioGroupBox.DataBindings.Add("Selected", _peopleBindingSource, nameof(Person.Gender));
        FirstNameTextBox.DataBindings.Add("Text", _peopleBindingSource, nameof(Person.FirstName));
        LastNameTextBox.DataBindings.Add("Text", _peopleBindingSource, nameof(Person.LastName));

        
    }
    
    /// <summary>
    /// Set current person's gender type
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void GenderRadioGroupBox_SelectedChanged(object sender, RadioGroupBox.SelectedChangedEventArgs e)
    {
        _peopleBindingList[_peopleBindingSource.Position].Gender = (GenderType)e.Selected;
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        var test = _peopleBindingList.ToList();
        File.WriteAllText("Mocked.json", JsonHelper.SerializePerson(_peopleBindingList.ToList()));
    }
}
