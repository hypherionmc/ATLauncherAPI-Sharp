using System;

namespace ATLauncherAPI.apiobjects.helpers
{
    public class PackVersionObject
    {
        private String version;
        private String minecraftVersion;
        private bool recommended;
        private int published;
        private String serverZipUrl;
        private String changelog;


        public PackVersionObject(String version, String minecraftVersion, bool recommended, int published, String serverZipUrl, String changelog) {
            this.version = version;
            this.minecraftVersion = minecraftVersion;
            this.recommended = recommended;
            this.published = published;
            this.serverZipUrl = serverZipUrl;
            this.changelog = changelog;
        }

        public String getVersion() {
            return version;
        }

        public bool isRecommended() {
            return recommended;
        }

        public int getPublished() {
            return published;
        }

        public String getChangelog() {
            return changelog;
        }

        public String getMinecraftVersion() {
            return minecraftVersion;
        }

        public String getServerZipUrl() {
            return serverZipUrl;
        }
    }
}