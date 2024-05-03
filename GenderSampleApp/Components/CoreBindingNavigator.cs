#nullable disable
namespace GenderSampleApp.Components;


public sealed class CoreBindingNavigator : BindingNavigator
{
    public CoreBindingNavigator()
    {
        AddStandardItems();
        
    }

    public void RemoveAddRemove(bool enable = false)
    {
        AddNewItem.Enabled = enable;
        DeleteItem.Enabled = enable;
    }
}