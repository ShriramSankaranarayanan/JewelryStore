
namespace JewelryStore
{
    interface IPrint
    {
        string PrintEstimation(IEstimationInput estimationInput,Enums.UserCategory userCategory);
    }
}
