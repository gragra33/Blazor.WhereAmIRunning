namespace Blazing.Common.Services;

public interface IUtilityService
{
    bool GetIsServerMode();

    bool GetIsWasmMode();

    WhereAmIRunningType WhereAmIRunning();
}