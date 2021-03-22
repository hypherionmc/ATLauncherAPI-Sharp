using System;

namespace ATLauncherAPI.apiobjects.helpers
{
    public class VersionsObject
    {
        private String version;
        private String minecraft;
        private int published;
        private String ___LINK;
        
        public VersionsObject(String version, String minecraft, int published, String link) {
            this.version = version;
            this.minecraft = minecraft;
            this.published = published;
            ___LINK = link;
        }

        public String getVersion() {
            return version;
        }

        public String getMinecraft() {
            return minecraft;
        }

        public int getPublished() {
            return published;
        }
        
    }
}