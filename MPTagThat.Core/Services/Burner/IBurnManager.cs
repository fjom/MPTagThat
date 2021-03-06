﻿#region Copyright (C) 2009-2011 Team MediaPortal
// Copyright (C) 2009-2011 Team MediaPortal
// http://www.team-mediaportal.com
// 
// MPTagThat is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
// 
// MPTagThat is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with MPTagThat. If not, see <http://www.gnu.org/licenses/>.
#endregion
#region

using System.Collections.Generic;

#endregion

namespace MPTagThat.Core.Burning
{
  public delegate void BurningError(BurnResult eBurnResult, ProjectType eProjectType);

  public delegate void BurnProgress(BurnStatus eBurnStatus, int eTrack, int ePercentage);

  /// <summary>
  ///   Interface for easy burning
  /// </summary>
  public interface IBurnManager
  {
    /// <summary>
    ///   This event will be fired whenever an error occurs that would require user interaction
    /// </summary>
    event BurningError BurningFailed;

    event BurnProgress BurnProgressUpdate;

    /// <summary>
    ///   Set the Active Burner
    /// </summary>
    /// <returns></returns>
    void SetActiveBurner(Burner burner);

    /// <summary>
    ///   Query all available drives
    /// </summary>
    /// <returns>whether the search returned usable data</returns>
    List<Burner> GetDrives();

    /// <summary>
    ///   Returns MediaInfo of the currebnt Drive
    /// </summary>
    /// <returns>Information about the currently inserted media</returns>
    MediaInfo GetMediaInfo();

    /// <summary>
    ///   Check whether it's generally possible to burn
    /// </summary>
    /// <param name = "aProjectType">Do you want to burn a Audio-CD, a DVD-Image, etc</param>
    /// <param name = "aCheckMediaStatus">Take current inserted media into account</param>
    /// <param name = "aBurnResult">Unknown as param, out = "Ready" if everything is okay, "UnsupportedMedia", etc if not</param>
    /// <returns>True if this project type can be handled</returns>
    bool IsBurningPossible(ProjectType aProjectType, bool aCheckMediaStatus, out BurnResult aBurnResult);

    /// <summary>
    ///   Retrieves the total size of all items including subdirectories
    /// </summary>
    /// <param name = "aPathname">The path to check</param>
    /// <returns>Accumulated size of files in MB (neither MiB nor space used on disk)</returns>
    int GetTotalMbForPath(string aPathname);

    /// <summary>
    ///   Erases rewriteable media
    /// </summary>
    /// <param name = "aUseFastMode">true only deletes the TOC, false does a full format</param>
    /// <returns>Whether the blanking succeded</returns>
    bool BlankDisk(bool aUseFastMode);

    /// <summary>
    ///   Burns the given file to disk - the ISO is not checked for consistency and will not be converted
    /// </summary>
    /// <param name = "aProjectType">Indicates whether we want e.g. a CD or DVD ISO.</param>
    /// <param name = "aIsoToBurn">Path to the ISO file</param>
    /// <returns>A specific status information about success or failure</returns>
    BurnResult BurnIsoFile(ProjectType aProjectType, string aIsoToBurn);

    /// <summary>
    ///   Burns all items in the given folder to disk
    /// </summary>
    /// <param name = "aProjectType">Indicates whether we want e.g. a CD or DVD ISO.</param>
    /// <param name = "aPathToBurn">A folder containing all items to be burnt</param>
    /// <returns>A specific status information about success or failure</returns>
    BurnResult BurnFolder(ProjectType aProjectType, string aPathToBurn);

    /// <summary>
    ///   Burns all items in the list to an Audio CD
    /// </summary>
    /// <param name = "aPathToBurn">List of Audio Files to Burn</param>
    /// <returns>A specific status information about success or failure</returns>
    BurnResult BurnAudioCd(List<string> aFilesToBurn);
  }
}