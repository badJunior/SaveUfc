
class Program
{

    static void Main(string[] args)
    {
      string  [] people = { "Tom", "Bob", "Sam", "Tim", "Tomas", "Bill" };

        // создаем новый список для результатов
        var selectedPeople = from p in people // передаем каждый элемент из people в переменную p
                              //фильтрация по критерию
                               // упорядочиваем по возрастанию
                             select p; // выбираем объект в создаваемую коллекцию

        foreach (string person in selectedPeople)
            Console.WriteLine(person);
    }

}