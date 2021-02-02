namespace CodeReuse.VirtualMachineExample
{
    public class Snapshot<T> where T: IResource
    {
        public T resource { get; set; }

        public Snapshot(T resource)
        {
            this.resource = resource;
        }
    }
}