namespace CodeReuse.VirtualMachineExample
{
    public class Volume : IResource
    {
        public int ResourceIdentifier { get; set; }

        private SnapshotCreator<Volume> _snapshotCreator;

        public Volume(SnapshotCreator<Volume> snapshotCreator)
        {
            _snapshotCreator = snapshotCreator;
        }

        public void CreateSnapshotOfVolume()
        {
            _snapshotCreator.CreateSnapshot(this);
        }
    }
}