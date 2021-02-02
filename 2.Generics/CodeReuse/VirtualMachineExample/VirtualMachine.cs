namespace CodeReuse.VirtualMachineExample
{
    public class VirtualMachine : IResource
    {
        public int ResourceIdentifier { get; set ; }

        private SnapshotCreator<VirtualMachine> _snapshotCreator;

        public VirtualMachine(SnapshotCreator<VirtualMachine> snapshotCreator)
        {
            _snapshotCreator = snapshotCreator;
        }

        public void CreateSnapshotOfVolume()
        {
            _snapshotCreator.CreateSnapshot(this);
        }
    }
}