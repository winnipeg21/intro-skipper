using MediaBrowser.Model.Plugins;

namespace ConfusedPolarBear.Plugin.IntroSkipper.Configuration;

/// <summary>
/// Plugin configuration.
/// </summary>
public class PluginConfiguration : BasePluginConfiguration
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PluginConfiguration"/> class.
    /// </summary>
    public PluginConfiguration()
    {
    }

    // ===== Analysis settings =====

    /// <summary>
    /// Gets or sets a value indicating whether the episode's fingerprint should be cached to the filesystem.
    /// </summary>
    public bool CacheFingerprints { get; set; } = true;

    /// <summary>
    /// Gets or sets the max degree of parallelism used when analyzing episodes.
    /// </summary>
    public int MaxParallelism { get; set; } = 2;

    /// <summary>
    /// Gets or sets the comma separated list of library names to analyze. If empty, all libraries will be analyzed.
    /// </summary>
    public string SelectedLibraries { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets a value indicating whether to analyze season 0.
    /// </summary>
    public bool AnalyzeSeasonZero { get; set; } = false;

    // ===== EDL handling =====

    /// <summary>
    /// Gets or sets a value indicating the action to write to created EDL files.
    /// </summary>
    public EdlAction EdlAction { get; set; } = EdlAction.None;

    /// <summary>
    /// Gets or sets a value indicating whether to regenerate all EDL files during the next scan.
    /// By default, EDL files are only written for a season if the season had at least one newly analyzed episode.
    /// If this is set, all EDL files will be regenerated and overwrite any existing EDL file.
    /// </summary>
    public bool RegenerateEdlFiles { get; set; } = false;

    // ===== Custom analysis settings =====

    /// <summary>
    /// Gets or sets the percentage of each episode's audio track to analyze.
    /// </summary>
    public int AnalysisPercent { get; set; } = 25;

    /// <summary>
    /// Gets or sets the upper limit (in minutes) on the length of each episode's audio track that will be analyzed.
    /// </summary>
    public int AnalysisLengthLimit { get; set; } = 10;

    /// <summary>
    /// Gets or sets the minimum length of similar audio that will be considered an introduction.
    /// </summary>
    public int MinimumIntroDuration { get; set; } = 15;

    /// <summary>
    /// Gets or sets the maximum length of similar audio that will be considered an introduction.
    /// </summary>
    public int MaximumIntroDuration { get; set; } = 120;

    // ===== Playback settings =====

    /// <summary>
    /// Gets or sets a value indicating whether introductions should be automatically skipped.
    /// </summary>
    public bool AutoSkip { get; set; }

    /// <summary>
    /// Gets or sets the seconds before the intro starts to show the skip prompt at.
    /// </summary>
    public int ShowPromptAdjustment { get; set; } = 5;

    /// <summary>
    /// Gets or sets the seconds after the intro starts to hide the skip prompt at.
    /// </summary>
    public int HidePromptAdjustment { get; set; } = 10;

    /// <summary>
    /// Gets or sets a value indicating whether the introduction in the first episode of a season should be skipped.
    /// </summary>
    public bool SkipFirstEpisode { get; set; } = true;

    /// <summary>
    /// Gets or sets the amount of intro to play (in seconds).
    /// </summary>
    public int SecondsOfIntroToPlay { get; set; } = 2;

    // ===== Internal algorithm settings =====

    /// <summary>
    /// Gets or sets the maximum number of bits (out of 32 total) that can be different between two Chromaprint points before they are considered dissimilar.
    /// Defaults to 6 (81% similar).
    /// </summary>
    public int MaximumFingerprintPointDifferences { get; set; } = 6;

    /// <summary>
    /// Gets or sets the maximum number of seconds that can pass between two similar fingerprint points before a new time range is started.
    /// </summary>
    public double MaximumTimeSkip { get; set; } = 3.5;

    /// <summary>
    /// Gets or sets the amount to shift inverted indexes by.
    /// </summary>
    public int InvertedIndexShift { get; set; } = 2;

    /// <summary>
    /// Gets or sets the maximum amount of noise (in dB) that is considered silent.
    /// Lowering this number will increase the filter's sensitivity to noise.
    /// </summary>
    public int SilenceDetectionMaximumNoise { get; set; } = -50;

    /// <summary>
    /// Gets or sets the minimum duration of audio (in seconds) that is considered silent.
    /// </summary>
    public double SilenceDetectionMinimumDuration { get; set; } = 0.33;
}
