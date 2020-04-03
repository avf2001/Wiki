```csharp
public abstract class Mediator
{
  public abstract void Send(string message, Colleague colleague);
}

public abstract class Colleague
{
  protected Mediator mediator;

  //public Colleague(Mediator mediator)
  //{
  //    this.mediator = mediator;
  //}

  internal void SetMediator(Mediator mediator)
  {
    this.mediator = mediator;
  }

  public virtual void Send(string message)
  {
    this.mediator.Send(message, this);
  }

  public abstract void HandleNotification(string message);
}

public class ConcreteMediator : Mediator
    {
        //public Colleague1 Colleague1 { get; set; }
        //public Colleague2 Colleague2 { get; set; }
        private List<Colleague> colleagues = new List<Colleague>();

        public void Register(Colleague colleague)
        {
            colleague.SetMediator(this);
            this.colleagues.Add(colleague);
        }

        public T CreateColleague<T>() where T : Colleague, new()
        {
            var c = new T();
            c.SetMediator(this);
            this.colleagues.Add(c);
            return c;
        }

        public override void Send(string message, Colleague colleague)
        {
            //if (colleague == this.Colleague1)
            //{
            //    this.Colleague2.HandleNotification(message);
            //}
            //else
            //{
            //    this.Colleague1.HandleNotification(message);
            //}

            this.colleagues.Where(c => c != colleague).ToList().ForEach(c => c.HandleNotification(message));

        }
    }

public class Colleague1 : Colleague
    {
        //public Colleague1(Mediator mediator) : base(mediator)
        //{
        //}

        public override void HandleNotification(string message)
        {
            Console.WriteLine($"Colleague1 receives notification message: {message}");
        }
    }

 public class Colleague2 : Colleague
    {
        //public Colleague2(Mediator mediator) : base(mediator)
        //{
        //}

        public override void HandleNotification(string message)
        {
            Console.WriteLine($"Colleague2 receives notification message: {message}");
        }
    }

var mediator = new ConcreteMediator();

//var c2 = new Colleague2();
////mediator.Colleague1 = c1;
////mediator.Colleague2 = c2;
//mediator.Register(c1);
//mediator.Register(c2);
var c1 = mediator.CreateColleague<Colleague1>();
var c2 = mediator.CreateColleague<Colleague2>();

c1.Send("Hello, World! (from c1)");
c2.Send("hi, there! (from c2)");

```
