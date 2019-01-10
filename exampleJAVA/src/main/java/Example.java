import com.google.gson.Gson;

import java.util.HashMap;

public class Example {

    private Http httpClient;

    public Example(Http httpClient) {
        this.httpClient = httpClient;
    }

    public int add(int a, int b) {
        return a + b;
    }

    public String getTitle() {
        String json = httpClient.getData("todos/1");
        String title = (String) new Gson().fromJson(json, HashMap.class).get("title");
        return title.toUpperCase();
    }
}
