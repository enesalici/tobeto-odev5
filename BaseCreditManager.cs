namespace tobeto_video_odev5
{
    public abstract class BaseCreditManager : ICreditManager
    {
        public abstract void Calculate(); // operasyonu değişken olduğu için abstract 

        public virtual void Save()
        {
            Console.WriteLine("Kaydedildi");
        }
    }
}
