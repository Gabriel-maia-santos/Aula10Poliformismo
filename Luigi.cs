namespace Aula10
{
    public class Luigi : Player
    {
        public override void Pular(){
            base.Pular();

            System.Console.WriteLine("O Luigi também pode pular 30% mais alto");
        }
    }
}