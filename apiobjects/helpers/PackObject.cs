using System;
using System.Collections.Generic;

namespace ATLauncherAPI.apiobjects.helpers
{
    public class PackObject
    {
        private int id;
        private string name;
        private string safeName;
        private string type;
        private List<VersionsObject> versions;
        private string description;
        private string discordInviteURL;
        private string supportURL;
        private string websiteURL;

        public PackObject(int id, string name, string safeName, string type, List<VersionsObject> versions,
            string description, string discordInviteURL, string supportURL, string websiteURL)
        {
            this.id = id;
            this.name = name;
            this.safeName = safeName;
            this.type = type;
            this.versions = versions;
            this.description = description;
            this.discordInviteURL = discordInviteURL;
            this.supportURL = supportURL;
            this.websiteURL = websiteURL;
        }
        
        /***
     * Gets the ID of the modpack
     * @return - INT
     */
        public int getPackId() {
            return id;
        }

        /***
         * Gets the Website URL of the modpack
         * @return
         */
        public String getWebsiteURL() {
            return websiteURL;
        }

        /***
         * Gets the pack type
         * @return (public, private, semipublic)
         */
        public String getType() {
            return type;
        }

        /***
         * Get the support URL for the modpack
         * @return
         */
        public String getSupportURL() {
            return supportURL;
        }

        /***
         * Gets the Safename of the Modpack (used in the URLs)
         * @return
         */
        public String getSafeName() {
            return safeName;
        }

        /***
         * Gets the description of the Modpack
         * @return
         */
        public String getDescription() {
            return description;
        }

        /***
         * Gets the Display name of the Modpack
         * @return
         */
        public String getName() {
            return name;
        }

        /***
         * Gets a list of all the published versions of the modpack
         * @return
         */
        public List<VersionsObject> getVersions() {
            return versions;
        }

        /***
         * Get the ATLauncher Info Page URL for the modpack
         * @return
         */
        public String getLink() {
            return "https://atlauncher.com/pack/" + getSafeName();
        }

        public string getDiscordURL()
        {
            return this.discordInviteURL;
        }
    }
}