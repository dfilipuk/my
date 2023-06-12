namespace ExternalAsyncOperation
{
    public abstract class BluetoothNativeDriver
    {
        /// <summary>
        /// Initiate search of bluetooth devices nearby.
        /// </summary>
        public void StartDevicesSearch() { }

        /// <summary>
        /// Onvoked once devices search is finished.
        /// </summary>
        /// <param name="ids">Array of device ids which were found nearby.</param>
        protected abstract void OnSearchFinish(string[] ids);

        /// <summary>
        /// Invoked once devices search is failed.
        /// </summary>
        /// <param name="error">Error details.</param>
        protected abstract void OnError(string error);
    }

    public class BluetoothDriver : BluetoothNativeDriver
    {
        private TaskCompletionSource<string[]> _tsc;
        
        /// <summary>
        /// Search bluetooth devices nearby.
        /// </summary>
        /// <returns>List of device ids which were found nearby. NULL in case of any error.</returns>
        public async Task<string[]> SearchDevices()
        {
            _tsc = new TaskCompletionSource<string[]>();

            StartDevicesSearch();

            return _tsc.Task;
        }

        protected override void OnSearchFinish(string[] ids)
        {
            _tsc.SetResult(ids);
        }

        protected override void OnError(string error)
        {
            _tsc.SetResult(null);
        }
    }
}