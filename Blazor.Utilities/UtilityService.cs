using Microsoft.JSInterop;

namespace Blazing.Common.Services;

public class UtilityService : IUtilityService
{
    #region Injects

    private readonly IJSRuntime _jsRuntime;

    #endregion

    #region Constructors

    public UtilityService(IJSRuntime jsRuntime)
        => _jsRuntime = jsRuntime;

    #endregion

    #region Fields

    private bool? _cachedIsServer;

    #endregion

    #region Methods

    public bool GetIsServerMode()
    {
        if (!_cachedIsServer.HasValue)
            _cachedIsServer = _jsRuntime is not IJSInProcessRuntime;

        return _cachedIsServer.Value;
    }

    public bool GetIsWasmMode()
        => !GetIsServerMode();

    public WhereAmIRunningType WhereAmIRunning()
        => GetIsServerMode() ? WhereAmIRunningType.Server : WhereAmIRunningType.Wasm;

    #endregion
}