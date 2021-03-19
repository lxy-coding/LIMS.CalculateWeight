C:\Windows\Microsoft.NET\Framework64\v4.0.30319\InstallUtil.exe %~dp0\LIMS.CalculateWeight.WS.exe
Net Start LIMS_CalculateWeightService
sc config LIMS_CalculateWeightService 
pause