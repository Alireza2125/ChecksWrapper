using Microsoft.Extensions.Options;

namespace ChecksWrapperApi.Wrapper
{
    public class ChecksWrapperOptions
    {
        public Uri Endpoint { get; set; } = default!;
        public string BusinessId { get; set; } = default!;
        public string BusinessToken { get; set; } = default!;
    }

    public class ChecksWrapperHandler : DelegatingHandler
    {
        private readonly IOptionsMonitor<ChecksWrapperOptions> _optionsMonitor;

        public ChecksWrapperHandler(IOptionsMonitor<ChecksWrapperOptions> optionsMonitor)
        {
            _optionsMonitor = optionsMonitor;
        }
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var currentValue = _optionsMonitor.CurrentValue;
            request.Headers.Add("businessId", currentValue.BusinessId);
            request.Headers.Add("businessToken", currentValue.BusinessToken);
            return base.SendAsync(request, cancellationToken);
        }
    }
}
