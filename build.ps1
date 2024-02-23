$buildPlatform = "Any CPU"

# Set the path to MSBuild on your system (Visual Studio Community edition)
$msbuildPath = "C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe"

# Set the path to your solution file (assuming it's in the same folder as build.ps1)
$solutionPath = Join-Path -Path $PSScriptRoot -ChildPath "AxataPOS.LogReader.sln"

# Set the build configuration (e.g., Debug or Release)
$buildConfiguration = "Release"

# Start building the solution
Write-Host "Build started."

$processStartInfo = New-Object System.Diagnostics.ProcessStartInfo
$processStartInfo.FileName = $msbuildPath
$processStartInfo.Arguments = "$solutionPath /t:Rebuild"
$processStartInfo.RedirectStandardOutput = $true
$processStartInfo.RedirectStandardError = $true
$processStartInfo.UseShellExecute = $false
$processStartInfo.CreateNoWindow = $true

$process = New-Object System.Diagnostics.Process
$process.StartInfo = $processStartInfo
$process.Start() | Out-Null
$process.WaitForExit()

# Capture and display the output and error messages
$output = $process.StandardOutput.ReadToEnd()
$errorOutput = $process.StandardError.ReadToEnd()
$process.WaitForExit(200)

# Display the output and error messages
Write-Host "Build output:"
Write-Host $output

Write-Host "Build error output:"
Write-Host $errorOutput

# Check if the build was successful
if ($process.ExitCode -eq 0) {
    Write-Host "Build successful."
} else {
    Write-Host "Build failed. Exit code: $($process.ExitCode)"
    exit 1
}
