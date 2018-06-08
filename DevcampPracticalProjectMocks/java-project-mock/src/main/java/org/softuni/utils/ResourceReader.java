package org.softuni.utils;


import org.springframework.http.ResponseEntity;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;

/**
 * This file is only for mocking purposes. Feel free to remove it at any time.
 * It is just a file reader that reads a file from the resources
 */
public class ResourceReader {

    public static String readResource(String fileName){

        InputStream is = ResourceReader.class.getResourceAsStream("/mocks/" + fileName);

        StringBuilder builder = new StringBuilder();

        InputStreamReader isr = new InputStreamReader(is);

        try (BufferedReader reader = new BufferedReader(isr)) {

            String line;
            while ((line = reader.readLine()) != null) {
                builder.append(line);
            }
        } catch (IOException ex) {
            ex.printStackTrace();
        }

        return builder.toString();
    }

}
