using System;
using System.Collections.Generic;
using ATLauncherAPI.apiobjects.helpers;

namespace ATLauncherAPI.apiobjects
{
    public class SimplePackResult
    {
        private bool error;
        private int code;
        private String message;
        private List<SimplePackObject> data;

        public SimplePackResult(bool error, int code, String message, List<SimplePackObject> data) {
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

        public List<SimplePackObject> getData() {
            return data;
        }

        public String getMessage() {
            return message;
        }
    }
}