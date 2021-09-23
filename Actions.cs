namespace Logger
{
    using System;

    public class Actions
    {
        private readonly Logger _logger;

        public Actions()
        {
            _logger = Logger.Instance;
        }

        public Result StartMethod()
        {
            _logger.LogInfo($"Start method: {nameof(StartMethod)}");
            return new Result() { Status = true };
        }

        public Result SkippedLogicMethod()
        {
            _logger.LogWarning($"Skipped logic in method: {nameof(SkippedLogicMethod)}");
            return new Result() { Status = true };
        }

        public Result ErrorMethod()
        {
            return new Result() { ErrorMessage = "I broke a logic" };
        }
    }
}
