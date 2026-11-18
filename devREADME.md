# Companion.Core Folder Structure:

**Models:** Data structures, such as flight telemetry.
**Services/Telemetry:** Communication with X-Plane.
**Services/Audio:** Music playback.
**Services/Flight:** Flight-phase detection.
**Services/Airline:** Airline-specific configurations.

## flightTelemetry.cs
Creates a data structure to hold flight telemetry information, including altitude, speed, and phase of flight.

## IXPlaneUdpListener.cs
Defines an interface for listening to X-Plane's UDP data, allowing for the reception of flight telemetry.