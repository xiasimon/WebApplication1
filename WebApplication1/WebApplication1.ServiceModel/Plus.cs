using ServiceStack;

namespace WebApplication1.ServiceModel
{
    [Route("/verb/{A}/{B}")]
    public class Plus : IReturn<PlusResponse>
    {
        public int A { get; set; }
        public int B { get; set; }
    }

    public class PlusResponse
    {
        public int Result { get; set; }
    }

    [Route("/sub/{A}/{B}")]
    public class Sub : IReturn<SubResponse>
    {
        public int A { get; set; }
        public int B { get; set; }
    }

    public class SubResponse
    {
        public int Result { get; set; }
    }
}