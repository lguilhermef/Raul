package queen.talls.raul.converter;

public interface RaulConverter<S, T> {

    public T convert(S source);
}
