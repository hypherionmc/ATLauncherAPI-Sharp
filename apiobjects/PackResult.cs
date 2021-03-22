using System;
using ATLauncherAPI.apiobjects.helpers;

namespace ATLauncherAPI.apiobjects
{
    public class PackResult
    {
        private bool error;
        private int code;
        private String message;
        private PackObject data;

        public PackResult(bool error, int code, String message, PackObject data) {
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

        public PackObject getData() {
            return data;
        }

        public String getMessage() {
            return message;
        }
    }
}