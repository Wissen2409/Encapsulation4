public class Personel{

 // eğer bir sınıfın değişkeni isen, adın field'fir
 // eğer metodun değişkeni isen adın değişkendir.
  
    private int id;
    private string name;

    private int age;

    // değişlkenler belirlendi. Bu değişkenleri kapsülleyecek olan yapıları yazalım
    // bugüne kadar görmüş olduğumuz kapsülleme yöntemi iki tane metot yazıp değişkenlere bu metotlar
    // üzerinden erişmek oluyordu.Get ve Set metotlar .net version 1 den itibaren yapılan bir kapsülleme
    // yöntemiydi.

    // c# da kapsülleme için yeni bir yapı öğrenmdik.
    // bu yeni yapı, metot uazmaktan daha kolay bir version
    // bu yeni yapının adı, Properties
    // Properties 

    /*public int Get_Id(){
        return id;
    }
    public void Set_Id(int id){
        this.id = id;
    }*/

    public int Id{

        // get bölümü, değişkenin değerini geri döner
        get{return this.id;}

        // set bölümü ise, dışarıdan almış olduğu değeri, değişkene atar!!!
        set{this.id=value;}
    }
    public string Name{
        get{return this.name;}
        set{this.name=value;}
    }
    public int Age{
        get{return this.age;}
        set{this.age=value;}

    }

}