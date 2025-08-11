// Not Required

namespace BASIC
{
    public interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }
        string Address { get; set; }

        void DisplayPersonDetails();
    }
}