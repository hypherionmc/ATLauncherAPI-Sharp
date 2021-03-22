using System;
using ATLauncherAPI.apiobjects.helpers;

namespace ATLauncherAPI.apiobjects
{
    public class PackVersionResult
    {
        private bool error;
        private int code;
        private String message;
        private PackVersionObject data;

        public PackVersionResult(bool error, int code, String message, PackVersionObject data) {
            this.error = error;
            this.code = code;
            this.message = message;
            this.data = data;
        }

        public int getCode() {
            return code;
        }

        public bool isError() {
            return error;
        }

        public PackVersionObject getData() {
            return data;
        }

        public String getMessage() {
            return message;
        }
    }
}