using XP12MusicCompanion.Core.Models;

namespace XP12MusicCompanion.Core.Services.Telemetry;

public interface IXPlaneUdpListener{
    FlightTelemetry CurrentTelemetry { get; }
    bool IsConnected { get; } // check if recieving data
    event Action<FlightTelemetry>? TelemetryUpdated;
    Task StartAsync(CancellationToken cancellationToken);
    Task StopAsync();
}
