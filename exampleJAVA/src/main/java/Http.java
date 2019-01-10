import org.springframework.web.client.RestTemplate;

public class Http {

    private static final String BASE_URL = "https://jsonplaceholder.typicode.com/";

    public String getData(String path) {
        return new RestTemplate().getForEntity(BASE_URL + path, String.class).getBody();
    }
}
