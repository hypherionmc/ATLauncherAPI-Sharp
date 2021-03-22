using System;
using System.Collections.Generic;
using ATLauncherAPI.apiobjects.helpers;

namespace ATLauncherAPI.apiobjects
{
    public class PackArrayResult
    {
        private bool error;
        private int code;
        private String message;
        private List<PackObject> data;

        public PackArrayResult(bool error, int code, String message, List<PackObject> data) {
            this.error = error;
            this.code = code;
            this.message = message;
            this.data = data;
        }

        /***
         * Get the error code returned by the API in the case of failure
         * @return
         */
        public int getCode() {
            return code;
        }

        /***
         * Check if the API call encountered an error
         * @return
         */
        public bool isError() {
            return error;
        }

        /***
         * Returns a PackObject containing the modpack info
         * @return
         */
        public List<PackObject> getData() {
            return data;
        }

        /***
         * Get the error message returned by the api. (NULL when no error)
         * @return
         */
        public String getMessage() {
            return message;
        }
    }
}