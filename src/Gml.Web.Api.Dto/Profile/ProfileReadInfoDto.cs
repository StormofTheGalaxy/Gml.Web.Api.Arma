using System.Collections.Generic;
using Gml.Web.Api.Dto.Files;

namespace Gml.Web.Api.Dto.Profile;

public class ProfileReadInfoDto
{
    public string JavaPath { get; set; }
    public string ProfileName { get; set; }
    public string MinecraftVersion { get; set; }
    public string ClientVersion { get; set; }
    public string IconBase64 { get; set; }
    public string Description { get; set; }
    public string Arguments { get; set; }
    public List<ProfileFileReadDto> Files { get; set; }
    public List<ProfileFileReadDto> WhiteListFiles { get; set; }
}