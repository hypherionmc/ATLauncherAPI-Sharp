using System;
using System.Net;
using System.Text;
using ATLauncherAPI.apiobjects;
using Newtonsoft.Json;

namespace ATLauncherAPI
{
    
    public class ATLauncherAPIClient
    {
        /* Private API Variables */
        private WebClient client = new WebClient() { Encoding = Encoding.UTF8 };
        private String apiurl = "https://api.atlauncher.com/v1/";
        private Logger logger = Logger.getLogger("AT-API");
        
        /***
         * Get info about a modpack
         * @param safename - The name of the modpack to search for (Case Sensitive and NO SPACES ALLOWED)
         * @return
         */
        public Optional<PackResult> getPackInfo(string safename)
        {
            try
            {
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                String response = client.DownloadString(apiurl + "pack/" + safename + "/");

                if (!string.IsNullOrEmpty(response))
                {
                    PackResult packResult = JsonConvert.DeserializeObject<PackResult>(response);
                    return new Optional<PackResult>(packResult);
                }
            }
            catch (Exception ex)
            {
                logger.error(ex.Message);
            }

            return new Optional<PackResult>();
        }
        
        /***
     * Get basic information about a single version of the modpack
     * @param safename - The name of the modpack to search for (Case Sensitive and NO SPACES ALLOWED)
     * @param version - Version to lookup (Use latest to get the newest version)
     * @return
     */
    public Optional<PackVersionResult> getPackVersion(String safename, String version) {
        try {
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            String response = client.DownloadString(apiurl + "pack/" + safename + "/" + version + "/");

            if (!string.IsNullOrEmpty(response))
            {
                PackVersionResult packVersionResult = JsonConvert.DeserializeObject<PackVersionResult>(response);
                return new Optional<PackVersionResult>(packVersionResult);
            } else {
                throw new Exception("Could not retrieve result from API");
            }
        } catch (Exception ex) {
            logger.error(ex.Message);
        }

        return new Optional<PackVersionResult>();
    }

    /***
     * Get a collection of basic information of all published modpacks
     * @return
     */
    public Optional<SimplePackResult> getSimplePackInfo() {
        
        try {
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            String response = client.DownloadString(apiurl + "packs/simple/");

            if (!string.IsNullOrEmpty(response))
            {
                SimplePackResult simplePackResult = JsonConvert.DeserializeObject<SimplePackResult>(response);
                return new Optional<SimplePackResult>(simplePackResult);
            } else {
                throw new Exception("Could not retrieve result from API");
            }
        } catch (Exception ex) {
            logger.error(ex.Message);
        }

        return new Optional<SimplePackResult>();
    }

    /***
     * Gets the full info about ALL published modpacks
     * @return
     */
    public Optional<PackArrayResult> getAllPacks() {
        
        try {
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            String response = client.DownloadString(apiurl + "packs/full/all/");

            if (!string.IsNullOrEmpty(response))
            {
                PackArrayResult packArrayResult = JsonConvert.DeserializeObject<PackArrayResult>(response);
                return new Optional<PackArrayResult>(packArrayResult);
            } else {
                throw new Exception("Could not retrieve result from API");
            }
        } catch (Exception ex) {
            logger.error(ex.Message);
        }

        return new Optional<PackArrayResult>();
    }

    /***
     * Gets the full info about ALL published modpacks marked as public
     * @return
     */
    public Optional<PackArrayResult> getPublicPacks() {
        
        try {
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            String response = client.DownloadString(apiurl + "packs/full/public/");

            if (!string.IsNullOrEmpty(response))
            {
                PackArrayResult packArrayResult = JsonConvert.DeserializeObject<PackArrayResult>(response);
                return new Optional<PackArrayResult>(packArrayResult);
            } else {
                throw new Exception("Could not retrieve result from API");
            }
        } catch (Exception ex) {
            logger.error(ex.Message);
        }

        return new Optional<PackArrayResult>();
    }

    /***
     * Gets the full info about ALL published modpacks marked as semi-public
     * @return
     */
    public Optional<PackArrayResult> getSemiPublicPacks() {
        try {
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            String response = client.DownloadString(apiurl + "packs/full/semipublic/");

            if (!string.IsNullOrEmpty(response))
            {
                PackArrayResult packArrayResult = JsonConvert.DeserializeObject<PackArrayResult>(response);
                return new Optional<PackArrayResult>(packArrayResult);
            } else {
                throw new Exception("Could not retrieve result from API");
            }
        } catch (Exception ex) {
            logger.error(ex.Message);
        }

        return new Optional<PackArrayResult>();
    }

    /***
     * Gets the full info about ALL published modpacks marked as private
     * @return
     */
    public Optional<PackArrayResult> getPrivatePacks() {
        try {
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            String response = client.DownloadString(apiurl + "packs/full/private/");

            if (!string.IsNullOrEmpty(response))
            {
                PackArrayResult packArrayResult = JsonConvert.DeserializeObject<PackArrayResult>(response);
                return new Optional<PackArrayResult>(packArrayResult);
            } else {
                throw new Exception("Could not retrieve result from API");
            }
        } catch (Exception ex) {
            logger.error(ex.Message);
        }

        return new Optional<PackArrayResult>();
    }
    }
}