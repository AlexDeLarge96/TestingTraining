import com.fasterxml.jackson.databind.ObjectMapper;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;
import org.mockito.Mock;
import org.mockito.MockitoAnnotations;

import java.io.IOException;
import java.net.URL;

import static org.mockito.Mockito.*;

public class ExampleTest {

    @Mock
    private Http httpClient;

    private Example example;

    @Before
    public void setUp() {
        MockitoAnnotations.initMocks(this);
        example = new Example(httpClient);
    }

    @Test
    public void testAddExpectingEquals() {
        //Perform Test
        int result = example.add(1, 2);

        //Verify
        Assert.assertEquals(3, result);
    }

    @Test
    public void testAddExpectingNotEquals() {
        //Perform Test
        int result = example.add(2, 2);

        //Verify
        Assert.assertNotEquals(5, result);
    }

    @Test
    public void testGetTitle() throws Exception {
        //Setup
        when(httpClient.getData(anyString())).thenReturn(getFakeJson());

        //Perform Test
        String result = example.getTitle();

        //Verify
        Assert.assertEquals("FAKE TITLE FOR TEST", result);
    }

    private String getFakeJson() throws IOException {
        ObjectMapper mapper = new ObjectMapper();
        URL resource = getClass().getClassLoader().getResource("FakeJson.json");
        return mapper.readTree(resource).toString();
    }
}