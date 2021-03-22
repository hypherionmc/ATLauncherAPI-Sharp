using System;

namespace ATLauncherAPI.apiobjects.helpers
{
    public class SimplePackObject
    {
        private int id;
        private String name;
        private String safeName;
        private String type;
        private String ___LINK;

        public SimplePackObject(int id, String name, String safeName, String type, String link) {
            this.id = id;
            this.name = name;
            this.safeName = safeName;
            this.type = type;
            ___LINK = link;
        }

        public String getName() {
            return name;
        }

        public String getSafeName() {
            return safeName;
        }

        public String getType() {
            return type;
        }

        public int getId() {
            return id;
        }

        public String getLink() {
            return "https://atlauncher.com/pack/" + getSafeName();
        }
    }
}